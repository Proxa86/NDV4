namespace NDV4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExcel = new System.Windows.Forms.Button();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.bInsertMarker = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBInformation = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bStartAnalysis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBSharp = new System.Windows.Forms.CheckBox();
            this.cBCpp = new System.Windows.Forms.CheckBox();
            this.cBFatran = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExcel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonExcel.Location = new System.Drawing.Point(7, 80);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonExcel.Size = new System.Drawing.Size(359, 27);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "Open report";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // listBoxReport
            // 
            this.listBoxReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.ItemHeight = 15;
            this.listBoxReport.Location = new System.Drawing.Point(4, 24);
            this.listBoxReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(362, 49);
            this.listBoxReport.TabIndex = 4;
            // 
            // bInsertMarker
            // 
            this.bInsertMarker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bInsertMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bInsertMarker.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bInsertMarker.Location = new System.Drawing.Point(7, 18);
            this.bInsertMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bInsertMarker.Name = "bInsertMarker";
            this.bInsertMarker.Size = new System.Drawing.Size(117, 46);
            this.bInsertMarker.TabIndex = 5;
            this.bInsertMarker.Text = "Insert marker";
            this.bInsertMarker.UseVisualStyleBackColor = false;
            this.bInsertMarker.Click += new System.EventHandler(this.buttonInsertMarker_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createStripMenuItem,
            this.openStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createStripMenuItem
            // 
            this.createStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.createStripMenuItem.Name = "createStripMenuItem";
            this.createStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.createStripMenuItem.Text = "Create Project";
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            this.openStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.openStripMenuItem.Text = "Open Project";
            this.openStripMenuItem.Click += new System.EventHandler(this.openStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBInformation);
            this.groupBox2.Controls.Add(this.listBoxReport);
            this.groupBox2.Controls.Add(this.buttonExcel);
            this.groupBox2.Location = new System.Drawing.Point(159, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(373, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open report in excel";
            // 
            // lBInformation
            // 
            this.lBInformation.AutoSize = true;
            this.lBInformation.Location = new System.Drawing.Point(131, 85);
            this.lBInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBInformation.Name = "lBInformation";
            this.lBInformation.Size = new System.Drawing.Size(0, 15);
            this.lBInformation.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bInsertMarker);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(14, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(131, 72);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert marker";
            // 
            // bStartAnalysis
            // 
            this.bStartAnalysis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bStartAnalysis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bStartAnalysis.Location = new System.Drawing.Point(7, 18);
            this.bStartAnalysis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bStartAnalysis.Name = "bStartAnalysis";
            this.bStartAnalysis.Size = new System.Drawing.Size(124, 52);
            this.bStartAnalysis.TabIndex = 1;
            this.bStartAnalysis.Text = "Start analisys";
            this.bStartAnalysis.UseVisualStyleBackColor = false;
            this.bStartAnalysis.Click += new System.EventHandler(this.bStartAnalysis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStartAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(14, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(138, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find marker in binary";
            // 
            // cBSharp
            // 
            this.cBSharp.AutoSize = true;
            this.cBSharp.Location = new System.Drawing.Point(6, 16);
            this.cBSharp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBSharp.Name = "cBSharp";
            this.cBSharp.Size = new System.Drawing.Size(41, 19);
            this.cBSharp.TabIndex = 10;
            this.cBSharp.Text = "C#";
            this.cBSharp.UseVisualStyleBackColor = true;
            this.cBSharp.CheckedChanged += new System.EventHandler(this.cBSharp_CheckedChanged);
            // 
            // cBCpp
            // 
            this.cBCpp.AutoSize = true;
            this.cBCpp.Location = new System.Drawing.Point(61, 16);
            this.cBCpp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBCpp.Name = "cBCpp";
            this.cBCpp.Size = new System.Drawing.Size(63, 19);
            this.cBCpp.TabIndex = 11;
            this.cBCpp.Text = "C/C++";
            this.cBCpp.UseVisualStyleBackColor = true;
            this.cBCpp.CheckedChanged += new System.EventHandler(this.cBCpp_CheckedChanged);
            // 
            // cBFatran
            // 
            this.cBFatran.AutoSize = true;
            this.cBFatran.Location = new System.Drawing.Point(127, 16);
            this.cBFatran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBFatran.Name = "cBFatran";
            this.cBFatran.Size = new System.Drawing.Size(59, 19);
            this.cBFatran.TabIndex = 12;
            this.cBFatran.Text = "Fatran";
            this.cBFatran.UseVisualStyleBackColor = true;
            this.cBFatran.CheckedChanged += new System.EventHandler(this.cBFatran_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBCpp);
            this.groupBox4.Controls.Add(this.cBFatran);
            this.groupBox4.Controls.Add(this.cBSharp);
            this.groupBox4.Location = new System.Drawing.Point(159, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(197, 43);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(539, 196);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.Button bInsertMarker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bStartAnalysis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lBInformation;
        private System.Windows.Forms.CheckBox cBSharp;
        private System.Windows.Forms.CheckBox cBCpp;
        private System.Windows.Forms.CheckBox cBFatran;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

