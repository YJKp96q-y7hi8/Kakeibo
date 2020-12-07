using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kakeibo
{
    public partial class uc_Menu : UserControl
    {
        public uc_Menu()
        {
            InitializeComponent();
        }

        public event EventHandler Click_BtnInput;
        public event EventHandler Click_BtnCalendar;

        protected virtual void OnEvent(EventHandler handle, EventArgs e)
        {
            var handler = handle;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            OnEvent(Click_BtnInput, e);
        }

        private void btn_Calendar_Click(object sender, EventArgs e)
        {
            OnEvent(Click_BtnCalendar, e);
        }
    }
}
