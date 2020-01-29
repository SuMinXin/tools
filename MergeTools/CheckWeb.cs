using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MergeTools
{

    public enum CheckType {
        IncludeAll,
        Exist
    }

    public enum HtmlPosition
    {
        Undefined,
        Header,
        Body,
        Script
    }
    public partial class CheckWebForm : Form
    {
        public CheckWebForm()
        {
            InitializeComponent();
        }

        private void CheckWebForm_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(menu_panel, this, 6);
            menu.drawButton();
        }
        private void btn_GO_Click(object sender, EventArgs e)
        {
            richTxt_Result.Text = string.Empty;
            runURL();
            checkHtml();
        }
        //全域變數
        private bool hasCanonical = false;
        private bool hasHttp = false;
        bool muchData = false;

        private void checkHtml() {
            string html = getHtmlFormWeb();
            StringReader strReader = new StringReader(html);
            StringBuilder chlResult = new StringBuilder();
            //資料分析
            Dictionary<String,StringBuilder> result = new Dictionary<string, StringBuilder>(); //<Title, Desc>
            HtmlPosition position = HtmlPosition.Undefined;
            HtmlPosition prevPosition = HtmlPosition.Undefined;
            //Para
            if (checkExist(txt_URL.Text, new List<string>() { "?", "&" }, CheckType.IncludeAll))
            {
                List<string> data = txt_URL.Text.Split('?')[1].Split('&').ToList();
                muchData = data.Count() > 5;
                foreach (string date in data) {
                    addContent(ref result, "Url Data", date);
                }
            }
            while (true)
            {
                //Read By Line
                string currrentTxt = strReader.ReadLine();
                if (currrentTxt == null)
                {
                    break;
                }
                else if (!string.IsNullOrWhiteSpace(currrentTxt)) {
                    #region - Check -
                    //Position
                    if (checkExist(currrentTxt, new List<string>() { "<head>" }, CheckType.Exist))
                    {
                        position = HtmlPosition.Header;
                    } else if (checkExist(currrentTxt, new List<string>() { "<body>" }, CheckType.Exist)) {
                        position = HtmlPosition.Body;
                    } else if (checkExist(currrentTxt, new List<string>() { "<script" }, CheckType.Exist)){
                        prevPosition = position;
                        position = HtmlPosition.Script;
                    }
                    else if (checkExist(currrentTxt, new List<string>() { "</script>" }, CheckType.Exist))
                    {
                        position = prevPosition;
                    }

                    //Canonical
                    if (checkExist(currrentTxt, new List<string>() { "link", "rel", "canonical" }, CheckType.IncludeAll))
                    {
                        string key = "Canonical";
                        addContent(ref result, key, currrentTxt);
                        hasCanonical = true;
                    }

                    //Title
                    if (position == HtmlPosition.Header && 
                        checkExist(currrentTxt, new List<string>() { "<title>" }, CheckType.Exist))
                    {
                        string[] httpString = currrentTxt.Split(new string[] { "<title>" }, StringSplitOptions.None);
                        result.Add("Title", new StringBuilder().AppendLine(httpString[1].Split(new string[] { "</title>" }, StringSplitOptions.None)[0]));
                    }

                    //Descriptions
                    if (checkExist(currrentTxt, new List<string>() { "Description" }, CheckType.Exist))
                    {
                        string key = string.Concat(position.ToString(), " " , "Description");
                        addContent(ref result, key, currrentTxt);
                    }

                    //Http
                    if (checkExist(currrentTxt, new List<string>() { "http:" }, CheckType.Exist))
                    {
                        string key = "Http Content";
                        string[] httpString = currrentTxt.Split(new string[] { "http:" }, StringSplitOptions.None);
                        for (int i = 1; i < httpString.Length; i++) {
                            addContent(ref result, key, string.Concat("http:", httpString[i].Split('"')[0]));
                        }
                        hasHttp = true;
                    }

                    //Image
                    if (checkExist(currrentTxt, new List<string>() { "<img" }, CheckType.Exist))
                    {
                        string key = "Images";
                        string[] img = currrentTxt.Split(new string[] { "src=\"" }, StringSplitOptions.None);
                        for (int i = 1; i < img.Length; i++)
                        {
                            addContent(ref result, key, img[i].Split('"')[0]);
                        }
                    }

                    //Link
                    if (checkExist(currrentTxt, new List<string>() { "<a href" }, CheckType.Exist))
                    {
                        string key = "Links";
                        string[] link = currrentTxt.Split(new string[] { "href=\"" }, StringSplitOptions.None);
                        for (int i = 1; i < link.Length; i++)
                        {
                            string linkurl = link[i].Split('"')[0];
                            string linkdesc = string.Empty;
                            string[] linkdescs = link[i].Split(new string[] { "title=" }, StringSplitOptions.None);
                            if (linkdescs.Length == 1)
                            {
                                if (checkExist(currrentTxt, new List<string>() { "<", ">" }, CheckType.IncludeAll)){
                                    linkdesc = linkdescs[0].Split('>')[1].Split('<')[0];
                                }
       
                            }
                            else {
                                linkdesc = linkdescs[1].Split('"')[1];
                            }
                            if (string.IsNullOrWhiteSpace(linkdesc)) {
                                addContent(ref result, key, link[i].Split('"')[0]);
                            } else {
                                addContent(ref result, key, string.Concat("[", linkdesc, "]", link[i].Split('"')[0]));
                            }
                           
                        }
                    }
                    #endregion
                }
            }
            printout(result);
         
        }

        private void printout(Dictionary<String, StringBuilder> result) {
            richTxt_Result.SelectionColor = System.Drawing.Color.Black;
            richTxt_Result.AppendText("執行結果:");
            richTxt_Result.AppendText(Environment.NewLine);
            foreach (KeyValuePair<string, StringBuilder> item in result)
            {
                richTxt_Result.SelectionColor = System.Drawing.Color.Maroon;
                richTxt_Result.AppendText(item.Key);
                richTxt_Result.AppendText(Environment.NewLine);
                richTxt_Result.SelectionColor = System.Drawing.Color.Black;
                richTxt_Result.AppendText(item.Value.ToString());
                richTxt_Result.AppendText(Environment.NewLine);
            }
            warning();
        }

        private void warning() {
            if (!hasCanonical || hasHttp || muchData)
            {
                richTxt_Result.SelectionColor = System.Drawing.Color.Red;
                richTxt_Result.AppendText("【WARN】");
                richTxt_Result.AppendText(Environment.NewLine);
                richTxt_Result.SelectionColor = System.Drawing.Color.Black;
                if (!hasCanonical)
                {
                    richTxt_Result.AppendText("未設定canonical, 請留意標準網址及版本問題");
                    richTxt_Result.AppendText(Environment.NewLine);
                }
                if (hasHttp)
                {
                    richTxt_Result.AppendText("網頁包含Http內容, 請留意安全性問題");
                    richTxt_Result.AppendText(Environment.NewLine);
                }
                if (muchData)
                {
                    richTxt_Result.AppendText("網址列帶入參數 > 5");
                    richTxt_Result.AppendText(Environment.NewLine);
                }
                richTxt_Result.SelectionColor = System.Drawing.Color.Black;
            }
        }

        private void addContent(ref Dictionary<String, StringBuilder> result, string key, string content) {
            if (result.ContainsKey(key))
            {
                result[key].AppendLine(content);
            }
            else
            {
                result.Add(key, new StringBuilder().AppendLine(content));
            }
        }

        private bool checkExist(string data, List<string> word, CheckType type) {
            foreach(string str in word) {
                if (data.IndexOf(str) < 0)
                {
                    if (type == CheckType.IncludeAll)
                    {
                        return false;
                    }
                }
                else {
                    if (type == CheckType.Exist)
                    {
                        return true;
                    }
                }
            }
            return (type == CheckType.IncludeAll);
        }
        private string getHtmlFormWeb()
        {
            string result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txt_URL.Text);
                request.Timeout = 30000; //Timeout : 30sec
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("utf-8"); //GB2312
                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                result = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get Html Exception:\n" + ex.ToString());
            }
            return result;
        }

        private void txt_URL_KeyUp(object sender, KeyEventArgs e)
        {
            // 使用者輸入完後，直接按 Entry 執行
            if (e.KeyCode == Keys.Enter) runURL();
        }

        private void runURL()
        {
            try {
                webBrowser.Navigate(txt_URL.Text);
            } catch (Exception ex) {
                MessageBox.Show("URL Exception:\n" + ex.ToString());
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 使用者操作 WebBrowser 內連結時，必須把點擊的 URL 傳回 txtURL 內顯示
            string url = webBrowser.Url.ToString();
            if (string.IsNullOrEmpty(url)) return;
            txt_URL.Text = url;
        }

        private void richTxt_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
