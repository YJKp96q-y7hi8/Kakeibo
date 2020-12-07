using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kakeibo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            int height = Screen.GetWorkingArea(this).Height;
            int width = Screen.GetWorkingArea(this).Width;
            int harfWidth = width / 2;

            this.SetDesktopLocation(width - harfWidth, 0);
            this.Width = harfWidth;
            this.Height = height;

            this.MinimumSize = new System.Drawing.Size(width / 3, this.Height);

            UcEventSet();
        }

        private uc_Input _Input;
        private uc_Calendar _Calendar;

        private void Click_BtnInput(object sender, EventArgs e)
        {
            this.tlp_Main.Controls.Clear();

            this._Input = new uc_Input();
            this.tlp_Main.Controls.Add(this._Input, 0, 0);

            this._Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Input.Name = "_Input";
        }

        private void Click_BtnCalendar(object sender, EventArgs e)
        {
            this.tlp_Main.Controls.Clear();

            this._Calendar = new uc_Calendar();
            this.tlp_Main.Controls.Add(this._Calendar, 0, 0);

            this._Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Calendar.Name = "_Calendar";
        }

        private void UcEventSet()
        {
            Menu.Click_BtnInput += new EventHandler(Click_BtnInput);
            Menu.Click_BtnCalendar += new EventHandler(Click_BtnCalendar);
        }
    }
}
