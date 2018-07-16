using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkManager.Classes.UI
{
    public enum XStyle
    {
        None,
        On,
        Active
    }

    public class XButton : Label
    {
        int id;
        Panel parent;

        public int ID
        {
            get
            {
                return id;
            }
        }

        public XButton(int id, Panel parent, string title)
        {
            this.parent = parent;
            this.id = id;

            Text = title;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            AutoSize = false;
            Dock = DockStyle.Fill;

            parent.Controls.Add(this);
        }

        public void SetStyle(XStyle style)
        {
            switch (style)
            {
                case XStyle.None:
                    BackColor = Color.White;
                    ForeColor = Color.Black;
                    break;

                case XStyle.On:
                    BackColor = Color.FromArgb(231, 241, 250);
                    ForeColor = Color.Black;
                    break;

                case XStyle.Active:
                    BackColor = Color.FromArgb(33, 117, 200);
                    ForeColor = Color.White;
                    break;
            }
        }

        public void RegisterEvent(EventHandler click,EventHandler on,EventHandler leave)
        {
            Click += click;
            MouseEnter += on;
            MouseLeave += leave;
        }
    }
}