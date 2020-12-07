namespace Kakeibo
{
    partial class uc_Calendar
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_UcCarendar = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Calender = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Saturday = new System.Windows.Forms.Label();
            this.lbl_Friday = new System.Windows.Forms.Label();
            this.lbl_Thursday = new System.Windows.Forms.Label();
            this.lbl_Wednesday = new System.Windows.Forms.Label();
            this.lbl_Tuesday = new System.Windows.Forms.Label();
            this.lbl_Monday = new System.Windows.Forms.Label();
            this.lbl_Sunday = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tlp_UcCarendar.SuspendLayout();
            this.tlp_Calender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_UcCarendar
            // 
            this.tlp_UcCarendar.ColumnCount = 4;
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_UcCarendar.Controls.Add(this.tlp_Calender, 0, 4);
            this.tlp_UcCarendar.Controls.Add(this.lbl_Title, 0, 0);
            this.tlp_UcCarendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UcCarendar.Location = new System.Drawing.Point(0, 0);
            this.tlp_UcCarendar.Name = "tlp_UcCarendar";
            this.tlp_UcCarendar.RowCount = 5;
            this.tlp_UcCarendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tlp_UcCarendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tlp_UcCarendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tlp_UcCarendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tlp_UcCarendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.tlp_UcCarendar.Size = new System.Drawing.Size(939, 738);
            this.tlp_UcCarendar.TabIndex = 0;
            this.tlp_UcCarendar.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlp_UcCarendar_CellPaint);
            // 
            // tlp_Calender
            // 
            this.tlp_Calender.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_Calender.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Calender.ColumnCount = 7;
            this.tlp_UcCarendar.SetColumnSpan(this.tlp_Calender, 4);
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlp_Calender.Controls.Add(this.lbl_Saturday, 6, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Friday, 5, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Thursday, 4, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Wednesday, 3, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Tuesday, 2, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Monday, 1, 0);
            this.tlp_Calender.Controls.Add(this.lbl_Sunday, 0, 0);
            this.tlp_Calender.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Calender.Location = new System.Drawing.Point(3, 258);
            this.tlp_Calender.Name = "tlp_Calender";
            this.tlp_Calender.RowCount = 5;
            this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlp_Calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlp_Calender.Size = new System.Drawing.Size(933, 313);
            this.tlp_Calender.TabIndex = 0;
            this.tlp_Calender.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlp_Calender_CellPaint);
            // 
            // lbl_Saturday
            // 
            this.lbl_Saturday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Saturday.AutoSize = true;
            this.lbl_Saturday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Saturday.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Saturday.Location = new System.Drawing.Point(802, 10);
            this.lbl_Saturday.Name = "lbl_Saturday";
            this.lbl_Saturday.Size = new System.Drawing.Size(127, 15);
            this.lbl_Saturday.TabIndex = 6;
            this.lbl_Saturday.Text = "土";
            this.lbl_Saturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Friday
            // 
            this.lbl_Friday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Friday.AutoSize = true;
            this.lbl_Friday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Friday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Friday.Location = new System.Drawing.Point(669, 10);
            this.lbl_Friday.Name = "lbl_Friday";
            this.lbl_Friday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Friday.TabIndex = 5;
            this.lbl_Friday.Text = "金";
            this.lbl_Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Thursday
            // 
            this.lbl_Thursday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Thursday.AutoSize = true;
            this.lbl_Thursday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Thursday.Location = new System.Drawing.Point(536, 10);
            this.lbl_Thursday.Name = "lbl_Thursday";
            this.lbl_Thursday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Thursday.TabIndex = 4;
            this.lbl_Thursday.Text = "木";
            this.lbl_Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Wednesday
            // 
            this.lbl_Wednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Wednesday.AutoSize = true;
            this.lbl_Wednesday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Wednesday.Location = new System.Drawing.Point(403, 10);
            this.lbl_Wednesday.Name = "lbl_Wednesday";
            this.lbl_Wednesday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Wednesday.TabIndex = 3;
            this.lbl_Wednesday.Text = "水";
            this.lbl_Wednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Tuesday
            // 
            this.lbl_Tuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tuesday.AutoSize = true;
            this.lbl_Tuesday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Tuesday.Location = new System.Drawing.Point(270, 10);
            this.lbl_Tuesday.Name = "lbl_Tuesday";
            this.lbl_Tuesday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Tuesday.TabIndex = 2;
            this.lbl_Tuesday.Text = "火";
            this.lbl_Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Monday
            // 
            this.lbl_Monday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Monday.AutoSize = true;
            this.lbl_Monday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Monday.Location = new System.Drawing.Point(137, 10);
            this.lbl_Monday.Name = "lbl_Monday";
            this.lbl_Monday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Monday.TabIndex = 1;
            this.lbl_Monday.Text = "月";
            this.lbl_Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sunday
            // 
            this.lbl_Sunday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sunday.AutoSize = true;
            this.lbl_Sunday.BackColor = System.Drawing.Color.Silver;
            this.lbl_Sunday.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sunday.Location = new System.Drawing.Point(4, 10);
            this.lbl_Sunday.Name = "lbl_Sunday";
            this.lbl_Sunday.Size = new System.Drawing.Size(126, 15);
            this.lbl_Sunday.TabIndex = 0;
            this.lbl_Sunday.Text = "日";
            this.lbl_Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Gainsboro;
            this.tlp_UcCarendar.SetColumnSpan(this.lbl_Title, 4);
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(933, 60);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "カレンダー";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_UcCarendar);
            this.Name = "uc_Calendar";
            this.Size = new System.Drawing.Size(939, 738);
            this.tlp_UcCarendar.ResumeLayout(false);
            this.tlp_UcCarendar.PerformLayout();
            this.tlp_Calender.ResumeLayout(false);
            this.tlp_Calender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_UcCarendar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Saturday;
        private System.Windows.Forms.Label lbl_Friday;
        private System.Windows.Forms.Label lbl_Thursday;
        private System.Windows.Forms.Label lbl_Wednesday;
        private System.Windows.Forms.Label lbl_Tuesday;
        private System.Windows.Forms.Label lbl_Monday;
        private System.Windows.Forms.Label lbl_Sunday;
        private System.Windows.Forms.TableLayoutPanel tlp_Calender;
    }
}
