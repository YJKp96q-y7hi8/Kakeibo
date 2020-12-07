namespace Kakeibo
{
    partial class uc_Calendar_Days
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Income = new System.Windows.Forms.Label();
            this.lbl_Outgo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Day, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Income, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Outgo, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(3, 0);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(28, 15);
            this.lbl_Day.TabIndex = 0;
            this.lbl_Day.Text = "day";
            // 
            // lbl_Income
            // 
            this.lbl_Income.AutoSize = true;
            this.lbl_Income.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Income.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Income.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Income.Location = new System.Drawing.Point(3, 49);
            this.lbl_Income.Name = "lbl_Income";
            this.lbl_Income.Size = new System.Drawing.Size(144, 49);
            this.lbl_Income.TabIndex = 1;
            this.lbl_Income.Text = "income";
            this.lbl_Income.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_Outgo
            // 
            this.lbl_Outgo.AutoSize = true;
            this.lbl_Outgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Outgo.ForeColor = System.Drawing.Color.Red;
            this.lbl_Outgo.Location = new System.Drawing.Point(3, 98);
            this.lbl_Outgo.Name = "lbl_Outgo";
            this.lbl_Outgo.Size = new System.Drawing.Size(144, 52);
            this.lbl_Outgo.TabIndex = 2;
            this.lbl_Outgo.Text = "outgo";
            this.lbl_Outgo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // uc_Calendar_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_Calendar_Days";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbl_Day;
        public System.Windows.Forms.Label lbl_Income;
        public System.Windows.Forms.Label lbl_Outgo;
    }
}
