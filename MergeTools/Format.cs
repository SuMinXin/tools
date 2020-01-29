using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;

 namespace MergeTools
{
    public partial class FormatForm : Form
    {
        #region Property
        public string Input { get; set; }
        public string Output { get; set; }
        public List<string> errMsg { get; set; }
        private const string EncryptKey = "LionExAPI";
        public enum ExportType
        {
            xml = 0,
            txt = 1
        }

        #endregion

        #region - LOAD -
        public FormatForm()
        {
            InitializeComponent();
        }

        private void Format_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(menu_panel, this, 8);
            menu.drawButton();
        }
        #endregion

        #region - 排版 -
        private void btn_Tran_Click(object sender, EventArgs e)
        {
            txtHiddenCount.Text = string.Empty;
            txtHiddenKey.Text = string.Empty;
            errMsg = new List<string>();
            Input = txt_Input.Text;

            #region - 字串檢核 -
            try
            {
                try
                {
                    richtxt_Output.Text = Input.Replace(@"""", @"\""");
                    resetFocus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(SystemMsg.format(ex.Message));
            }
            #endregion

        }

        private void btn_toJson_Click(object sender, EventArgs e)
        {
            txtHiddenCount.Text = string.Empty;
            txtHiddenKey.Text = string.Empty;
            errMsg = new List<string>();
            Input = txt_Input.Text;

            #region - 字串檢核 -
            try
            {
                Input = Setting.ReplaceExtra(Input);
                //排版字符
                if (!string.IsNullOrWhiteSpace(txt_Split.Text))
                {
                    Input = Input.Replace(txt_Split.Text, string.Concat(txt_Split.Text, Setting.LINE));
                }
                if (Input.IndexOf("{") > -1)
                {
                    try
                    {
                        richtxt_Output.Text = PraseToJson(Input);
                        //dll 問題
                        //var jsonObj = JsonConvert.DeserializeObject(Input);
                        //richtxt_Output.Text = JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    }
                    catch
                    {
                        richtxt_Output.Text = Input;
                    }
                }
                else {
                    try
                    {
                        string _formatStr = FormatXml(Input);
                        richtxt_Output.Text = _formatStr.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                    } catch{
                        richtxt_Output.Text = Input;
                    }
                }
                resetFocus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SystemMsg.format(ex.Message));
            }
            #endregion

        }
        #endregion

        #region - 加/解密(Compress) -
        private void btn_Compress_Click(object sender, EventArgs e)
        {
            txtHiddenCount.Text = string.Empty;
            txtHiddenKey.Text = string.Empty;
            try {
                richtxt_Output.Text = Compress(txt_Input.Text);
                resetFocus();
            }
            catch(Exception ex) {
                MessageBox.Show(SystemMsg.serializer(ex.Message));
            }
        }
        private void btn_DeCompress_Click(object sender, EventArgs e)
        {
            txtHiddenCount.Text = string.Empty;
            txtHiddenKey.Text = string.Empty;
            try {
                string _decompressStr = Decompress(txt_Input.Text);
                _decompressStr = Setting.ReplaceExtra(_decompressStr);
                _decompressStr = FormatXml(_decompressStr);
                richtxt_Output.Text = _decompressStr.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                resetFocus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SystemMsg.serializer(ex.Message));
            }
        }

        public string FormatXml(string inputXml)
        {
            try {
                XmlDocument document = new XmlDocument();
                document.Load(new StringReader(inputXml));

                StringBuilder builder = new StringBuilder();
                using (XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder)))
                {
                    writer.Formatting = System.Xml.Formatting.Indented;
                    document.Save(writer);
                }
                return builder.ToString();
            } catch {
                return inputXml;
            }
        }

        private string Decompress(string compressedText)
        {
            string result = Encoding.UTF8.GetString(Decompress(base64_decode(compressedText)));
            return result;
        }
        private byte[] base64_decode(string encodedData)
        {
            byte[] encodedDataAsBytes = Convert.FromBase64String(encodedData);
            return encodedDataAsBytes;
        }
        private byte[] Decompress(byte[] data)
        {
            byte[] buffer = new byte[0];
            using (var memoryStream = new MemoryStream())
            {
                // *because use BitConvert.Toint32 the byteLength will contain much empty code(ascii 0)
                // *so dont do that . should use memory stream to copy bytes

                // int byteLength =BitConverter.ToInt32(data, 0);
                //memoryStream.Write(data, 4, data.Length - 4);
                //buffer =  new byte[byteLength];
                memoryStream.Write(data, 0, data.Length);
                memoryStream.Position = 0;

                using (var mso = new MemoryStream())
                {
                    using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                    {
                        //gZipStream.Read(buffer, 0, buffer.Length);
                        gZipStream.CopyTo(mso);
                    }
                    buffer = mso.ToArray();
                }
            }
            return buffer;
        }
        private string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);
            return Convert.ToBase64String(compressed); //(gzBuffer);
        }
        #endregion

        #region - 加/解密(Encrypt) -
        private AesCryptoServiceProvider SetAes() {
            return new AesCryptoServiceProvider()
            {
                IV = getIVData(),
                Key = getKeyData(),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
        }
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            Input = txt_Input.Text;
            if (!string.IsNullOrWhiteSpace(Input))
            {
                try {
                    AesCryptoServiceProvider provider_AES = SetAes();
                    byte[] byteContent = Encoding.UTF8.GetBytes(Input);
                    byte[] byteEncrypt = provider_AES.CreateEncryptor().TransformFinalBlock(byteContent, 0, byteContent.Length);
                    richtxt_Output.Text = ByteArrayToHexString(byteEncrypt);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                richtxt_Output.Text = string.Empty;
            }
           
        }
        private string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", string.Empty);
        }
        private byte[] getKeyData()
        {
            return new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(EncryptKey));
        }
        private byte[] getIVData()
        {
            return new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(EncryptKey));
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            Input = txt_Input.Text;
            if (!string.IsNullOrWhiteSpace(Input))
            {
                try {
                    AesCryptoServiceProvider provider_AES = SetAes();
                    byte[] byteContent = HexStringToByteArray(Input);
                    byte[] byteDecrypt = provider_AES.CreateDecryptor().TransformFinalBlock(byteContent, 0, byteContent.Length);
                    richtxt_Output.Text = Encoding.UTF8.GetString(byteDecrypt);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                richtxt_Output.Text = string.Empty;
            }
        }

        private byte[] HexStringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        #endregion

        #region - Radio Button -
        private void radioBtn_Format_CheckedChanged(object sender, EventArgs e)
        {
            HideAllBtn();
            btn_Tran.Show();
            btn_toJson.Show();
        }

        private void radioBtn_Compress_CheckedChanged(object sender, EventArgs e)
        {
            HideAllBtn();
            btn_Compress.Show();
            btn_DeCompress.Show();
        }

        private void radioBtn_Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            HideAllBtn();
            btn_Encrypt.Show();
            btn_Decrypt.Show();
        }

        private void HideAllBtn() {
            btn_Compress.Hide();
            btn_DeCompress.Hide();
            btn_Tran.Hide();
            btn_toJson.Hide();
            btn_Encrypt.Hide();
            btn_Decrypt.Hide();
        }
        #endregion

        //清除
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Input.Text = string.Empty;
            txtHiddenCount.Text = string.Empty;
            txtHiddenKey.Text = string.Empty;
        }

        #region - 排版 -
        public string PraseToJson(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented,
                    Indentation = 2,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }

            //str = str.Replace(" ", "");
            int _space = 5;
            var tabIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var cr = str[i];

                if (cr == '{' || cr == '[')
                {
                    var prestr = str.Substring(0, i);
                    var strsuff = str.Substring(i + 1, str.Length - i - 1);
                    str = prestr + cr + "\n" + getSpace(tabIndex + 1, _space) + strsuff;

                    i += (1 + _space * (tabIndex + 1));
                    tabIndex++;
                }
                else if (cr == '}' || cr == ']')
                {
                    var prestr = str.Substring(0, i);
                    var strsuff = str.Substring(i + 1, str.Length - i - 1);
                    str = prestr + "\n" + getSpace(tabIndex - 1, _space) + cr + strsuff;

                    i += (1 + _space * (tabIndex - 1));
                    tabIndex--;

                }
                else if (cr == ',')
                {
                    var prestr = str.Substring(0, i + 1);
                    var strsuff = str.Substring(i + 1, str.Length - i - 1);
                    str = prestr + "\n" + getSpace(tabIndex, _space) + strsuff;
                    i += (1 + _space * tabIndex);
                }
            }

            return str.Trim();
        }

        private string getSpace(int num, int _space)
        {
            string result = string.Empty;
            string str = string.Empty;
            for (int i = 0; i < num; i++)
            {
                result += str.PadRight(_space, ' ');
            }

            return result;
        }
        #endregion

        private void showMessage()
        {
            string alertMsg = string.Empty;
            foreach (string msg in errMsg)
            {
                alertMsg = string.Concat(alertMsg, msg, Setting.LINE);
            }
            MessageBox.Show(alertMsg);
        }

        #region - 按鈕 -
        //複製
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            string text = this.richtxt_Output.Text;
            Clipboard.SetText(text);
        }

        //匯出
        private void btn_ExportTxt_Click(object sender, EventArgs e)
        {
            Export(ExportType.txt);
        }
        private void btn_ExportXml_Click(object sender, EventArgs e)
        {
            Export(ExportType.xml);
        }

        private void Export(ExportType type) {
            string action = "匯出";
            try {
                string txtPath = string.Concat(@"E:\Data\Desktop\", txt_ExportName.Text, ".", type.ToString());

                using (StreamWriter sw = new StreamWriter(txtPath))
                {
                    sw.Write(richtxt_Output.Text);
                }
                MessageBox.Show(SystemMsg.succeed(action));
            } catch (Exception ex) {
                MessageBox.Show(SystemMsg.fail(action, ex.ToString()));
            }
        }
        #endregion


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            #region - Search -
            if (keyData == (Keys.Control | Keys.F))
            {
                txtSearch.Show();
                txtSearch.Focus();
                txtSearch.Text = string.Empty;
                return true;
            }

            if (keyData == Keys.Enter && txtSearch.Focused)
            {
                if (string.Compare(richtxt_Output.Text, txtSearch.Text,true) == 0) {
                    MessageBox.Show("內容與查詢字串完全相同");
                    return true;
                }
                List<string> allText = richtxt_Output.Text.Split(new string[] { txtSearch.Text }, StringSplitOptions.RemoveEmptyEntries).ToList();
                int Current = 0;
                int idx = 0;
                if (txtHiddenKey.Text == txtSearch.Text && allText.Count() > 1)
                {
                    //Find Next
                    idx = Convert.ToInt16(string.IsNullOrWhiteSpace(txtHiddenCount.Text) ? "0" : txtHiddenCount.Text); //目前位置
                    if (allText.Count() - 1 == idx)
                    {
                        idx = richtxt_Output.Text.IndexOf(txtSearch.Text);
                        txtHiddenCount.Text = "1";
                    }
                    else
                    {
                        idx = 0;
                        for (int i = 0; i <= Convert.ToInt16(txtHiddenCount.Text); i++)
                        {
                            idx += (allText[i].Length);
                            if (i < Convert.ToInt16(txtHiddenCount.Text) - 1)
                            {
                                idx += (txtSearch.Text.Length);
                            }
                        }
                        txtHiddenCount.Text = (Convert.ToInt16(txtHiddenCount.Text) + 1).ToString();
                    }
                }
                else {
                    idx = richtxt_Output.Text.IndexOf(txtSearch.Text);
                    txtHiddenCount.Text = "1";
                }
                Current = Convert.ToInt16(txtHiddenCount.Text);

                richtxt_Output.Text = string.Empty;
                int counter = 0;
                foreach (string item in allText)
                {
                    counter++;
                    richtxt_Output.SelectionColor = System.Drawing.Color.Black;
                    richtxt_Output.SelectionBackColor = System.Drawing.Color.GhostWhite;
                    richtxt_Output.AppendText(item);
                    if (counter != allText.Count())
                    {
                        if (counter == Current)
                        {
                            richtxt_Output.SelectionBackColor = System.Drawing.Color.LemonChiffon;
                        }
                        else
                        {
                            richtxt_Output.SelectionBackColor = System.Drawing.Color.PeachPuff;
                        }
                        richtxt_Output.SelectionColor = System.Drawing.Color.Red;
                        richtxt_Output.AppendText(txtSearch.Text);
                    }
                }
                richtxt_Output.Focus();
                richtxt_Output.SelectionLength = 0;
                if (richtxt_Output.Text.IndexOf(txtSearch.Text) > -1)
                {
                    richtxt_Output.SelectionStart = idx;
                }
                else {
                    txtHiddenCount.Text = string.Empty;
                    txtHiddenKey.Text = string.Empty;
                    richtxt_Output.Focus();
                    richtxt_Output.SelectionLength = 0;
                    richtxt_Output.SelectionStart = 0;
                }
                if (txtHiddenKey.Text != txtSearch.Text ) {
                    MessageBox.Show(string.Format("共找到 {0} 個項目", (allText.Count() > 0 ? allText.Count() - 1 : 0)));
                }
                txtHiddenKey.Text = txtSearch.Text;
                txtSearch.Focus();
            }
            #endregion

            #region Select All
            if (keyData == (Keys.Control | Keys.A))
            {
                txt_Input.Focus();
                txt_Input.SelectAll();
            }
            #endregion

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void resetFocus() {
            txtSearch.Hide();
            richtxt_Output.Focus();
            richtxt_Output.SelectionLength = 0;
            richtxt_Output.SelectionStart = 0;
        }

        #region - class -
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void richtxt_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void lstb_Input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void txt_Q1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q1_Ans_Click(object sender, EventArgs e)
        {

        }

        private void txt_Q3Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void tool_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
