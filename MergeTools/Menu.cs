using System.Collections.Generic;
using System.Windows.Forms;

namespace MergeTools
{
    public class Menu
    {
        private Panel menuPanel;
        private Form form;
        private int panelCol = 0;
        public Menu(Panel panel, Form form, int panelCol = 5) {
            this.panelCol = panelCol;
            this.menuPanel = panel;
            this.form = form;
        }
        public void drawButton() {
            List<Button> btnList = DrawButton.drawbtn(panelCol, menuPanel, form);
            btnList.ForEach(btn => { menuPanel.Controls.Add(btn); });
        }
    }
}
