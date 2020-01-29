using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MergeTools
{
    public partial class Base64Form : Form
    {
        public Base64Form()
        {
            InitializeComponent();
            Menu menu = new Menu(menu_panel, this);
            menu.drawButton();
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            txt_Path.Text = file.FileName;
            txt_Name.Text = file.SafeFileName;
            lbl_output.Text = "執行結果";
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            string action = "匯出";
            //E:\Data\Desktop\1602771667677_GTZXXE_YEHCHIAYUMR.rtf
            try
            {
                string path = txt_Path.Text;
                string fileContent = FileToString(txt_Path.Text); //轉64

                //匯出成txt
                string txtPath = string.Concat(txt_Path.Text.Split('.')[0], ".txt");
                using (StreamWriter sw = new StreamWriter(txtPath))
                {
                    sw.Write(fileContent);
                }
                lbl_output.Text =SystemMsg.succeed(action);
            }
            catch(Exception ex) {
                lbl_output.Text = SystemMsg.fail(action, ex.Message);
            }
        }

        #region Method
        /// <summary>
        /// 轉換為Stream
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="dataBytes"></param>
        /// <returns></returns>
        public string FileToString(string FilePath)
        {
            try
            {
                //取得檔案 & 轉64
                using (FileStream reader = new FileStream(FilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[reader.Length];
                    reader.Read(buffer, 0, (int)reader.Length);
                    return Convert.ToBase64String(buffer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return string.Empty;
        }
        /// <summary>
        /// Stream轉文件
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="fileName"></param>
        public static void StreamToFile(Stream stream, string fileName)
        {
            // 把 Stream 转换成 byte[]   
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始   
            stream.Seek(0, SeekOrigin.Begin);

            // 把 byte[] 写入文件   
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bytes);
            bw.Close();
            fs.Close();
        }
        #endregion

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
