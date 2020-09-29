namespace NDV4
{
    partial class CreateNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCreateNewProject = new System.Windows.Forms.GroupBox();
            this.cbCopyFolder = new System.Windows.Forms.CheckBox();
            this.bSourceFolder = new System.Windows.Forms.Button();
            this.tbSourceFolder = new System.Windows.Forms.TextBox();
            this.lSourceFolder = new System.Windows.Forms.Label();
            this.bLocationProject = new System.Windows.Forms.Button();
            this.tbLocationProject = new System.Windows.Forms.TextBox();
            this.lLocationProject = new System.Windows.Forms.Label();
            this.tbNameProject = new System.Windows.Forms.TextBox();
            this.lNameProject = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.gbCreateNewProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateNewProject
            // 
            this.gbCreateNewProject.Controls.Add(this.cbCopyFolder);
            this.gbCreateNewProject.Controls.Add(this.bSourceFolder);
            this.gbCreateNewProject.Controls.Add(this.tbSourceFolder);
            this.gbCreateNewProject.Controls.Add(this.lSourceFolder);
            this.gbCreateNewProject.Controls.Add(this.bLocationProject);
            this.gbCreateNewProject.Controls.Add(this.tbLocationProject);
            this.gbCreateNewProject.Controls.Add(this.lLocationProject);
            this.gbCreateNewProject.Controls.Add(this.tbNameProject);
            this.gbCreateNewProject.Controls.Add(this.lNameProject);
            this.gbCreateNewProject.Location = new System.Drawing.Point(15, 15);
            this.gbCreateNewProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCreateNewProject.Name = "gbCreateNewProject";
            this.gbCreateNewProject.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCreateNewProject.Size = new System.Drawing.Size(477, 152);
            this.gbCreateNewProject.TabIndex = 0;
            this.gbCreateNewProject.TabStop = false;
            this.gbCreateNewProject.Text = "Project";
            // 
            // cbCopyFolder
            // 
            this.cbCopyFolder.AutoSize = true;
            this.cbCopyFolder.Checked = true;
            this.cbCopyFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyFolder.Enabled = false;
            this.cbCopyFolder.Location = new System.Drawing.Point(379, 108);
            this.cbCopyFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCopyFolder.Name = "cbCopyFolder";
            this.cbCopyFolder.Size = new System.Drawing.Size(90, 19);
            this.cbCopyFolder.TabIndex = 8;
            this.cbCopyFolder.Text = "Copy Folder";
            this.cbCopyFolder.UseVisualStyleBackColor = true;
            // 
            // bSourceFolder
            // 
            this.bSourceFolder.Location = new System.Drawing.Point(335, 104);
            this.bSourceFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSourceFolder.Name = "bSourceFolder";
            this.bSourceFolder.Size = new System.Drawing.Size(37, 27);
            this.bSourceFolder.TabIndex = 7;
            this.bSourceFolder.Text = "...";
            this.bSourceFolder.UseVisualStyleBackColor = true;
            this.bSourceFolder.Click += new System.EventHandler(this.bSourceFolder_Click);
            // 
            // tbSourceFolder
            // 
            this.tbSourceFolder.Location = new System.Drawing.Point(112, 104);
            this.tbSourceFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSourceFolder.Name = "tbSourceFolder";
            this.tbSourceFolder.Size = new System.Drawing.Size(215, 23);
            this.tbSourceFolder.TabIndex = 6;
            // 
            // lSourceFolder
            // 
            this.lSourceFolder.AutoSize = true;
            this.lSourceFolder.Location = new System.Drawing.Point(8, 104);
            this.lSourceFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSourceFolder.Name = "lSourceFolder";
            this.lSourceFolder.Size = new System.Drawing.Size(82, 15);
            this.lSourceFolder.TabIndex = 5;
            this.lSourceFolder.Text = "Source Folder:";
            // 
            // bLocationProject
            // 
            this.bLocationProject.Location = new System.Drawing.Point(335, 59);
            this.bLocationProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bLocationProject.Name = "bLocationProject";
            this.bLocationProject.Size = new System.Drawing.Size(37, 27);
            this.bLocationProject.TabIndex = 4;
            this.bLocationProject.Text = "...";
            this.bLocationProject.UseVisualStyleBackColor = true;
            this.bLocationProject.Click += new System.EventHandler(this.bLocationProject_Click);
            // 
            // tbLocationProject
            // 
            this.tbLocationProject.Location = new System.Drawing.Point(79, 59);
            this.tbLocationProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLocationProject.Name = "tbLocationProject";
            this.tbLocationProject.Size = new System.Drawing.Size(248, 23);
            this.tbLocationProject.TabIndex = 3;
            // 
            // lLocationProject
            // 
            this.lLocationProject.AutoSize = true;
            this.lLocationProject.Location = new System.Drawing.Point(8, 63);
            this.lLocationProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLocationProject.Name = "lLocationProject";
            this.lLocationProject.Size = new System.Drawing.Size(56, 15);
            this.lLocationProject.TabIndex = 2;
            this.lLocationProject.Text = "Location:";
            // 
            // tbNameProject
            // 
            this.tbNameProject.Location = new System.Drawing.Point(61, 20);
            this.tbNameProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNameProject.Name = "tbNameProject";
            this.tbNameProject.Size = new System.Drawing.Size(266, 23);
            this.tbNameProject.TabIndex = 1;
            // 
            // lNameProject
            // 
            this.lNameProject.AutoSize = true;
            this.lNameProject.Location = new System.Drawing.Point(8, 23);
            this.lNameProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameProject.Name = "lNameProject";
            this.lNameProject.Size = new System.Drawing.Size(42, 15);
            this.lNameProject.TabIndex = 0;
            this.lNameProject.Text = "Name:";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(27, 174);
            this.bOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(88, 27);
            this.bOK.TabIndex = 9;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(161, 174);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(88, 27);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // CreateNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 213);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.gbCreateNewProject);
            this.Controls.Add(this.bOK);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateNewProject";
            this.Text = "Create New Project";
            this.Load += new System.EventHandler(this.CreateNewProject_Load);
            this.gbCreateNewProject.ResumeLayout(false);
            this.gbCreateNewProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateNewProject;
        private System.Windows.Forms.TextBox tbLocationProject;
        private System.Windows.Forms.Label lLocationProject;
        private System.Windows.Forms.TextBox tbNameProject;
        private System.Windows.Forms.Label lNameProject;
        private System.Windows.Forms.Button bLocationProject;
        private System.Windows.Forms.CheckBox cbCopyFolder;
        private System.Windows.Forms.Button bSourceFolder;
        private System.Windows.Forms.TextBox tbSourceFolder;
        private System.Windows.Forms.Label lSourceFolder;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
    }
}