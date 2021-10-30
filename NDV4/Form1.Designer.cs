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
            this.cBFortran = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbOptimQmake = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbFile = new System.Windows.Forms.CheckBox();
            this.cbExcel = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cBClearResultBin = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.buttonExcel.Size = new System.Drawing.Size(348, 27);
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
            this.listBoxReport.Size = new System.Drawing.Size(351, 49);
            this.listBoxReport.TabIndex = 4;
            // 
            // bInsertMarker
            // 
            this.bInsertMarker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bInsertMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bInsertMarker.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bInsertMarker.Location = new System.Drawing.Point(6, 18);
            this.bInsertMarker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bInsertMarker.Name = "bInsertMarker";
            this.bInsertMarker.Size = new System.Drawing.Size(124, 68);
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
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
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
            this.groupBox2.Location = new System.Drawing.Point(159, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(367, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export report";
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
            this.groupBox3.Location = new System.Drawing.Point(7, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(138, 93);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert marker";
            // 
            // bStartAnalysis
            // 
            this.bStartAnalysis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bStartAnalysis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bStartAnalysis.Location = new System.Drawing.Point(6, 19);
            this.bStartAnalysis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bStartAnalysis.Name = "bStartAnalysis";
            this.bStartAnalysis.Size = new System.Drawing.Size(124, 65);
            this.bStartAnalysis.TabIndex = 1;
            this.bStartAnalysis.Text = "Start analisys";
            this.bStartAnalysis.UseVisualStyleBackColor = false;
            this.bStartAnalysis.Click += new System.EventHandler(this.bStartAnalysis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStartAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(7, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(138, 90);
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
            // cBFortran
            // 
            this.cBFortran.AutoSize = true;
            this.cBFortran.Location = new System.Drawing.Point(127, 16);
            this.cBFortran.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBFortran.Name = "cBFortran";
            this.cBFortran.Size = new System.Drawing.Size(64, 19);
            this.cBFortran.TabIndex = 12;
            this.cBFortran.Text = "Fortran";
            this.cBFortran.UseVisualStyleBackColor = true;
            this.cBFortran.CheckedChanged += new System.EventHandler(this.cBFatran_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cBCpp);
            this.groupBox4.Controls.Add(this.cBFortran);
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
            // cbOptimQmake
            // 
            this.cbOptimQmake.AutoSize = true;
            this.cbOptimQmake.Location = new System.Drawing.Point(6, 18);
            this.cbOptimQmake.Name = "cbOptimQmake";
            this.cbOptimQmake.Size = new System.Drawing.Size(82, 19);
            this.cbOptimQmake.TabIndex = 14;
            this.cbOptimQmake.Text = "Off qmake";
            this.cbOptimQmake.UseVisualStyleBackColor = true;
            this.cbOptimQmake.CheckedChanged += new System.EventHandler(this.cbOptimQmake_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbOptimQmake);
            this.groupBox5.Location = new System.Drawing.Point(159, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 43);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Optimization";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbFile);
            this.groupBox6.Controls.Add(this.cbExcel);
            this.groupBox6.Location = new System.Drawing.Point(256, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 44);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Check report";
            // 
            // cbFile
            // 
            this.cbFile.AutoSize = true;
            this.cbFile.Location = new System.Drawing.Point(67, 18);
            this.cbFile.Name = "cbFile";
            this.cbFile.Size = new System.Drawing.Size(69, 19);
            this.cbFile.TabIndex = 1;
            this.cbFile.Text = "File *.txt";
            this.cbFile.UseVisualStyleBackColor = true;
            this.cbFile.CheckedChanged += new System.EventHandler(this.cbFile_CheckedChanged);
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Location = new System.Drawing.Point(7, 18);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Size = new System.Drawing.Size(53, 19);
            this.cbExcel.TabIndex = 0;
            this.cbExcel.Text = "Excel";
            this.cbExcel.UseVisualStyleBackColor = true;
            this.cbExcel.CheckedChanged += new System.EventHandler(this.cbExcel_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cBClearResultBin);
            this.groupBox7.Location = new System.Drawing.Point(402, 80);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(100, 43);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Clear result";
            // 
            // cBClearResultBin
            // 
            this.cBClearResultBin.AutoSize = true;
            this.cBClearResultBin.Location = new System.Drawing.Point(6, 16);
            this.cBClearResultBin.Name = "cBClearResultBin";
            this.cBClearResultBin.Size = new System.Drawing.Size(88, 19);
            this.cBClearResultBin.TabIndex = 0;
            this.cBClearResultBin.Text = "Clear Result";
            this.cBClearResultBin.UseVisualStyleBackColor = true;
            this.cBClearResultBin.CheckedChanged += new System.EventHandler(this.cBClearResultBin_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(533, 245);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.CheckBox cBFortran;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbOptimQmake;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbFile;
        private System.Windows.Forms.CheckBox cbExcel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cBClearResultBin;
    }
}

