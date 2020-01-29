using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MergeTools
{
    public static class DrawButton
    {
        private enum FormName {
            Formatter,
            ConnectionStirng,
            CheckWeb,
            MongoLog,
            Base64
        }
        private static List<MenuPara> menu = new List<MenuPara>() {
            new MenuPara(){
                Name = "Data Format",
                OpenForm = FormName.Formatter,
                Orderby = 1
            },
            new MenuPara(){
                Name = "Connect String",
                OpenForm = FormName.ConnectionStirng,
                Orderby = 2
            },
            new MenuPara(){
                Name = "Check Html",
                OpenForm = FormName.CheckWeb,
                Orderby = 10
            },
              new MenuPara(){
                Name = "Mongo Log",
                OpenForm = FormName.MongoLog,
                Orderby = 3
            },
            new MenuPara(){
                Name = "Base64",
                OpenForm = FormName.Base64,
                Orderby = 11
            },
        };
        public static List<Button> drawbtn(int panelCol, Panel menuPanel, Form form)
        {
            List<Button> result = new List<Button>();
            //拆!
            List<List<MenuPara>> _menu = new List<List<MenuPara>>();
            for (int i = 0; i < menu.Count; i = i + panelCol)
            {
                _menu.Add(menu.Skip(i).Take(panelCol).ToList());
            }

            int rowCount = 0;
            foreach (List<MenuPara> _row in _menu)
            {
                int colCount = 0;
                foreach (MenuPara item in _row)
                {
                    Button btn = new Button()
                    {
                        Left = 110 * colCount,
                        Top = 50 * rowCount,
                        Width = 110,
                        Height = 45,
                        Text = item.Name,
                        ForeColor = System.Drawing.Color.PapayaWhip,
                        Font = new System.Drawing.Font(Setting.TEXT, 10, System.Drawing.FontStyle.Bold),
                    };
                    btn.Click += delegate (object o, EventArgs e) {
                        Click_Handler(item.OpenForm, form);
                    };
                    result.Add(btn);
                    menuPanel.Controls.Add(btn);
                    colCount++;
                }
                rowCount++;
            }
            return result;
        }

        private static void Click_Handler(FormName openForm, Form form)
        {
            try
            {
                
                switch (openForm) {
                    case FormName.Formatter:
                        new FormatForm().Show();
                        break;
                    case FormName.ConnectionStirng:
                        new ConnectForm().Show();
                        break;
                    case FormName.CheckWeb:
                        new CheckWebForm().Show();
                        break;
                    case FormName.MongoLog:
                        new MongoForm().Show();
                        break;
                    case FormName.Base64:
                        new Base64Form().Show();
                        break;
                    default:
                        MessageBox.Show(string.Concat("Form ", openForm, " is not defined."));
                        break;
                }
                form.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Form Failed：", ex.ToString()));
            }
        }
        class MenuPara
        {
            public string Name { get; set; }
            public FormName OpenForm { get; set; }
            public int Orderby { get; set; }
        }
    }
}
