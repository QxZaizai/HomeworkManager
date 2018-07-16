using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HomeworkManager.Classes.UI;

namespace HomeworkManager.Forms
{
    public partial class HomePage : Form
    {
        XButtonMgr mgr = new XButtonMgr();
        List<Panel> list = new List<Panel>();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            tabControl1.Region = new Region
                (new RectangleF(tabPage1.Left, tabPage1.Top, tabPage1.Width, tabPage1.Height));
            mgr.Register(this.tabControl1);
            for (int i = 0; i < 5; i++)
            {
                Panel temp = new Panel();
                Point point = new Point();
                point.X = 10;
                point.Y = 10 + (60 + 10) * i;
                temp.Location = point;
                temp.Width = 100;
                temp.Height = 60;
                list.Add(temp);
            }

            for (int i = 0; i < 5; i++)
            {
                Controls.Add(list[i]);
                mgr.New(list[i], "Button " + i.ToString());
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
