namespace Kakeibo
{
    partial class uc_Menu
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
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_Calendar = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Setting, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Report, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Calendar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Input, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Input
            // 
            this.btn_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Input.Location = new System.Drawing.Point(3, 3);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(214, 89);
            this.btn_Input.TabIndex = 0;
            this.btn_Input.Text = "入力";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_Calendar
            // 
            this.btn_Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Calendar.Location = new System.Drawing.Point(223, 3);
            this.btn_Calendar.Name = "btn_Calendar";
            this.btn_Calendar.Size = new System.Drawing.Size(214, 89);
            this.btn_Calendar.TabIndex = 1;
            this.btn_Calendar.Text = "カレンダー";
            this.btn_Calendar.UseVisualStyleBackColor = true;
            this.btn_Calendar.Click += new System.EventHandler(this.btn_Calendar_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Report.Location = new System.Drawing.Point(443, 3);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(214, 89);
            this.btn_Report.TabIndex = 2;
            this.btn_Report.Text = "レポート";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Setting.Location = new System.Drawing.Point(663, 3);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(215, 89);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "設定";
            this.btn_Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "メニュー";
            // 
            // uc_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_Menu";
            this.Size = new System.Drawing.Size(887, 116);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Calendar;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
