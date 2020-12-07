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
    public partial class uc_Calendar : UserControl
    {
        public uc_Calendar()
        {
            InitializeComponent();
            UcCalendarDaysSet();
        }

        internal List<uc_Calendar_Days> _Days = new List<uc_Calendar_Days>();

        private void tlp_Calender_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //一つおきにセルの背景色を変更する
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Silver, e.CellBounds);
            }
        }

        private void tlp_UcCarendar_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //一つおきにセルの背景色を変更する
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Gainsboro, e.CellBounds);
            }
        }

        private void UcCalendarDaysSet()
        {
            DateTime today = DateTime.Now;
            DateTime firstDay = new DateTime(today.Year, today.Month, 1);
            int firstDayOfWeek = (int)firstDay.DayOfWeek;

            int daysNum = DateTime.DaysInMonth(today.Year, today.Month);
            int beforDaysNum;
            if(today.Month != 1)
                beforDaysNum = DateTime.DaysInMonth(today.Year, today.Month - 1);
            else
                beforDaysNum = DateTime.DaysInMonth(today.Year - 1, 12);

            for (int i = 0; i < daysNum + firstDayOfWeek; i++)
            {
                if(((i / 7) + 1) > tlp_Calender.RowCount - 1)
                {
                    this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
                }
                AddDays(i);

                if (i < firstDayOfWeek)
                {
                    _Days[i].lbl_Day.Text = (daysNum - firstDayOfWeek + i).ToString();
                    _Days[i].ForeColor = System.Drawing.Color.LightGray;
                    _Days[i].lbl_Income.ForeColor = System.Drawing.Color.DeepSkyBlue;
                    _Days[i].lbl_Outgo.ForeColor = System.Drawing.Color.LightSalmon;
                    continue;
                }

                _Days[i].lbl_Day.Text = ((i - firstDayOfWeek)+ 1).ToString();
            }

            for (int i = daysNum + firstDayOfWeek; i < daysNum + firstDayOfWeek + 7 ; i++)
            {
                if(i % 7 == 0) { break; }

                AddDays(i);

                _Days[i].lbl_Day.Text = (i -(daysNum + firstDayOfWeek) + 1).ToString();
                _Days[i].ForeColor = System.Drawing.Color.LightGray;
                _Days[i].lbl_Income.ForeColor = System.Drawing.Color.DeepSkyBlue;
                _Days[i].lbl_Outgo.ForeColor = System.Drawing.Color.LightSalmon;
            }
        }

        private void AddDays(int i)
        {
            uc_Calendar_Days newDay = new uc_Calendar_Days();
            _Days.Add(newDay);

            int numX = i % 7;
            int numY = i / 7 + 1;
            tlp_Calender.Controls.Add(_Days[i], numX, numY);
        }
    }
}
