using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MergeTools
{
    public partial class MongoForm : Form
    {
        public int panelCol = 1;
        public int correntFormHeight = 0;
        public int panelWidth = 0;
        public MongoForm()
        {
            InitializeComponent();
        }

        private void MongoForm_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(menu_panel, this);
            menu.drawButton();
            try
            {
                //Step 1.取得檔案
                List<JsonPara> _menu = new List<JsonPara>();
                string FilePath = @"../doc/MongoJson.txt";
                string _strFromtxt = string.Empty;
                using (StreamReader sr = new StreamReader(FilePath, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        _strFromtxt += line;
                    }
                }
                _menu = JsonConvert.DeserializeObject<List<JsonPara>>(_strFromtxt);
                _menu = _menu.OrderBy(o => o.Orderby).ToList(); //Order By


                //Step 2.處理BTN
                showOnPanel(_menu);

                //其他有的沒的
                btn_Copy.FlatAppearance.BorderSize = 0;
                //btn_Copy.BackgroundImageLayout = ImageLayout.None;
                btn_Copy.FlatStyle = FlatStyle.Flat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(SystemMsg.serializer(ex.ToString()));
            }
        }
        private void showOnPanel(List<JsonPara> menu)
        {
            //拆!
            List<List<JsonPara>> _menu = new List<List<JsonPara>>();
            List<JsonPara> _temp = new List<JsonPara>();
            foreach (JsonPara item in menu)
            {
                if (item.Orderby % 10 == 0)
                {
                    _menu.Add(_temp);
                    _temp = new List<JsonPara>();
                }
                _temp.Add(item);
            }
            _menu.Add(_temp); //Last Group

            int rowCount = 0;
            foreach (List<JsonPara> _row in _menu)
            {
                int _Left = 3;
                int colCount = 0;
                foreach (JsonPara item in _row)
                {
                    Button btn = new Button()
                    {
                        Left = _Left,
                        Top = 40 * rowCount,
                        AutoSize = true,
                        Text = item.Name,
                        Font = new Font(Setting.TEXT, 10),
                        AccessibleName = item.JsonString,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Gainsboro
                    };
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += new EventHandler(myClick);
                    panel_Btn.Controls.Add(btn);

                    _Left += (btn.Width + 5);
                    colCount++;
                }
                rowCount++;
            }
            SetLocation(panel_Btn);
            richTxt_Output.Visible = false;

            #region -直的-
            /*直的
          int rowCount = 0;
          int LineCount = 0;
          int maxLength = 0;
          foreach (JsonPara item in menu)
          {
              //分隔線
              if (item.Orderby % 10 == 0) {
                  Label _line = new Label();
                  _line.Left = 5;
                  _line.Width = 100;
                  _line.Text = "--------------------";
                  _line.Top = 40 * rowCount + 20 * LineCount;
                  _line.Height = 10;
                  panel_Btn.Controls.Add(_line);
                  LineCount++;
              }

              Button btn = new Button();
              btn.Left = 5;
              btn.Top = 40 * rowCount + 20 * LineCount;
              btn.Height = 30;
              btn.Text = item.Name;
              btn.AutoSize = true;
              btn.Font = new Font("Microsoft JhengHei", 10);
              btn.AccessibleName = item.JsonString;
              btn.Click += new EventHandler(myClick);
              panel_Btn.Controls.Add(btn);
              if (item.Name.Length > maxLength)
              {
                  maxLength = item.Name.Length;
              }
              rowCount++;
          }
          panelWidth = panel_Btn.Width = maxLength * 20;
          this.Width = panel_Btn.Width + richTxt_Output.Width;
          this.Height = correntFormHeight = panel_Btn.Height + 50;
          */
            #endregion
        }
        private void myClick(object sender, EventArgs e)
        {
            try
            {
                richTxt_Output.SelectionColor = Color.YellowGreen;
                richTxt_Output.Text = formatDate(((Button)sender).AccessibleName);
                //StringFormat(((Button)sender).AccessibleName);
                SetRichTextBoxColor(richTxt_Output);
                lbl_Name.Text = ((Button)sender).Text;
                richTxt_Output.Visible = true;
                SetLocation(panel_Btn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(SystemMsg.exception(ex.ToString()));
            }
        }

        private string formatDate(string data) {
            DateTime now = DateTime.Now;
            data = data.Replace("@YearOnly", now.ToString(GetEnumDescription(Setting.DateFormat.Year)));
            data = data.Replace("@YearMonth", now.ToString(GetEnumDescription(Setting.DateFormat.YearMonth)));
            //FullDateTime
            data = data.Replace("@FullDateTime_T", now.ToString(GetEnumDescription(Setting.DateFormat.FullDateTimeWithT)));
            data = data.Replace("@FullDateTimeStart", now.ToString(GetEnumDescription(Setting.DateFormat.FullDateTimeStart)));
            data = data.Replace("@FullDateTimeEnd", now.ToString(GetEnumDescription(Setting.DateFormat.FullDateTimeEnd)));
            data = data.Replace("@FullDateTime", now.ToString(GetEnumDescription(Setting.DateFormat.FullDateTime)));
            //Ago
            data = data.Replace("@TenMinutesAgo", now.AddMinutes(-10).ToString(GetEnumDescription(Setting.DateFormat.FullDateTime)));
            data = data.Replace("@AnHourAgo_T", now.AddHours(-1).ToString(GetEnumDescription(Setting.DateFormat.FullDateTimeWithT)));
            data = data.Replace("@AnHourAgo", now.AddHours(-1).ToString(GetEnumDescription(Setting.DateFormat.FullDateTime)));
            
            return data;
        }

        private void SetLocation(object sender)
        {
            lbl_Name.Location = new Point(5, ((Panel)sender).Height + 30);
            richTxt_Output.Location = new Point(5, lbl_Name.Location.Y + 30);
            int _Height = richTxt_Output.Lines.Count() * 28;
            int _Width = richTxt_MaxLength(richTxt_Output);
            richTxt_Output.Size = new Size(_Width, _Height);
            _Width = richTxt_Output.Width > ((Panel)sender).Width ? richTxt_Output.Width : ((Panel)sender).Width;
            _Height = ((Panel)sender).Height + richTxt_Output.Height;
            this.Size = new Size(_Width + 40, _Height + 130);
        }
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.richTxt_Output.Text) || this.richTxt_Output.Text.IndexOf("getCollection") > -1)
            {
                ProcessStartInfo objProcess = new ProcessStartInfo(@"C:\Program Files\Robo 3T 1.1.1\robo3t.exe");
                objProcess.UseShellExecute = false;
                objProcess.RedirectStandardOutput = true;

                Process.Start(objProcess);
            }
            if (!string.IsNullOrWhiteSpace(this.richTxt_Output.Text))
            {
                Clipboard.SetText(this.richTxt_Output.Text);
            }
        }

        #region -一時興起的換顏色-
        public void SetRichTextBoxColor(RichTextBox richTextBox)
        {
            List<string> _white = new List<string>() { "find", "$gt", "$lt", "$gte", "$lte", "sort", "limit", " $match", "$group", "aggregate" };
            List<string> _orange = new List<string>() { "(", ")", "{", "}", ":", ",", "." };
            List<string> _lightblue = new List<string>() { "ISODate" };

            SetColor(richTextBox, _white, Color.White);
            SetColor(richTextBox, _orange, Color.DarkOrange);
            SetColor(richTextBox, _lightblue, Color.DeepSkyBlue);
        }

        private void SetColor(RichTextBox richTextBox, List<string> StrList, Color color)
        {
            foreach (string str in StrList)
            {
                ArrayList list = getIndexArray(richTextBox.Text, str);
                for (int i = 0; i < list.Count; i++)
                {
                    int index = (int)list[i];
                    richTextBox.Select(index, str.Length);
                    richTextBox.SelectionColor = color;
                }
            }
        }

        private ArrayList getIndexArray(String inputStr, String findStr)
        {
            ArrayList list = new ArrayList();
            int start = 0;
            while (start < inputStr.Length)
            {
                int index = inputStr.IndexOf(findStr, start);
                if (index >= 0)
                {
                    list.Add(index);
                    start = index + findStr.Length;
                }
                else
                {
                    break;
                }
            }
            return list;
        }


        #endregion
        private int richTxt_MaxLength(RichTextBox RichTextBox)
        {
            int max = 0;
            for (int i = 0; i < RichTextBox.Lines.Count(); i++)
            {
                if (max < RichTextBox.Lines[i].Count())
                {
                    max = RichTextBox.Lines[i].Count();
                }
            }
            return max == 0 ? RichTextBox.Size.Width : max * 8;
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //若取不到屬性，則取名稱
            if ((attributes != null) && (attributes.Length > 0))
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }

    public class JsonPara
    {
        public string Name { get; set; }
        public string JsonString { get; set; }
        public int Orderby { get; set; }
    }
}
