using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkManager.Classes.UI
{
    public class XButtonMgr
    {
        List<XButton> list;
        TabControl c;

        int activeItem;

        public XButtonMgr()
        {
            list = new List<XButton>();
            activeItem = -1;
        }

        public void Register(TabControl c)
        {
            this.c = c;
        }

        private void Leave(object sender, EventArgs e)
        {
            XButton t = (XButton)sender;

            if (activeItem != t.ID)
            {
                t.SetStyle(XStyle.None);
            }
        }

        private void On(object sender, EventArgs e)
        {
            XButton t = (XButton)sender;

            if (activeItem != t.ID)
            {
                t.SetStyle(XStyle.On);
            }
        }

        private void Click(object sender, EventArgs e)
        {
            XButton t = (XButton)sender;

            activeItem = t.ID;
            t.SetStyle(XStyle.Active);

            foreach (XButton item in list)
            {
                if (item.ID != t.ID)
                    item.SetStyle(XStyle.None);
            }

            c.SelectedIndex = t.ID;
        }

        public void New(Panel parent, string title)
        {
            XButton button = new XButton(list.Count, parent, title);
            button.RegisterEvent(Click, On, Leave);
            list.Add(button);
        }
    }
}
