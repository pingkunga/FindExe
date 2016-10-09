namespace FindExe
{
    partial class FindExeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindExeForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.btnSaveBasePath = new System.Windows.Forms.Button();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.lblBasePath = new System.Windows.Forms.Label();
            this.splitBody = new System.Windows.Forms.SplitContainer();
            this.treeBasePath = new System.Windows.Forms.TreeView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.gpbCriteria = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkTypeOCX = new System.Windows.Forms.CheckBox();
            this.chkTypeDLL = new System.Windows.Forms.CheckBox();
            this.chkFileExtension = new System.Windows.Forms.CheckBox();
            this.chkTypeEXE = new System.Windows.Forms.CheckBox();
            this.maskVersion = new System.Windows.Forms.MaskedTextBox();
            this.chkFileVersion = new System.Windows.Forms.CheckBox();
            this.txtFileNameContain = new System.Windows.Forms.TextBox();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.lblSearchPath = new System.Windows.Forms.Label();
            this.txtSearchPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).BeginInit();
            this.splitBody.Panel1.SuspendLayout();
            this.splitBody.Panel2.SuspendLayout();
            this.splitBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gpbCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.btnSaveBasePath);
            this.splitMain.Panel1.Controls.Add(this.txtBasePath);
            this.splitMain.Panel1.Controls.Add(this.lblBasePath);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitBody);
            this.splitMain.Size = new System.Drawing.Size(851, 391);
            this.splitMain.SplitterDistance = 45;
            this.splitMain.TabIndex = 0;
            // 
            // btnSaveBasePath
            // 
            this.btnSaveBasePath.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBasePath.Image")));
            this.btnSaveBasePath.Location = new System.Drawing.Point(809, 4);
            this.btnSaveBasePath.Name = "btnSaveBasePath";
            this.btnSaveBasePath.Size = new System.Drawing.Size(31, 33);
            this.btnSaveBasePath.TabIndex = 3;
            this.btnSaveBasePath.UseVisualStyleBackColor = true;
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(79, 11);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(723, 20);
            this.txtBasePath.TabIndex = 2;
            // 
            // lblBasePath
            // 
            this.lblBasePath.AutoSize = true;
            this.lblBasePath.Location = new System.Drawing.Point(14, 14);
            this.lblBasePath.Name = "lblBasePath";
            this.lblBasePath.Size = new System.Drawing.Size(59, 13);
            this.lblBasePath.TabIndex = 1;
            this.lblBasePath.Text = "Base Path:";
            this.lblBasePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitBody
            // 
            this.splitBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBody.Location = new System.Drawing.Point(0, 0);
            this.splitBody.Name = "splitBody";
            // 
            // splitBody.Panel1
            // 
            this.splitBody.Panel1.Controls.Add(this.treeBasePath);
            // 
            // splitBody.Panel2
            // 
            this.splitBody.Panel2.Controls.Add(this.dgvList);
            this.splitBody.Panel2.Controls.Add(this.gpbCriteria);
            this.splitBody.Size = new System.Drawing.Size(851, 342);
            this.splitBody.SplitterDistance = 251;
            this.splitBody.TabIndex = 0;
            // 
            // treeBasePath
            // 
            this.treeBasePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeBasePath.Location = new System.Drawing.Point(0, 0);
            this.treeBasePath.Name = "treeBasePath";
            this.treeBasePath.Size = new System.Drawing.Size(251, 342);
            this.treeBasePath.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 172);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(572, 158);
            this.dgvList.TabIndex = 3;
            // 
            // gpbCriteria
            // 
            this.gpbCriteria.Controls.Add(this.btnClear);
            this.gpbCriteria.Controls.Add(this.btnSearch);
            this.gpbCriteria.Controls.Add(this.chkTypeOCX);
            this.gpbCriteria.Controls.Add(this.chkTypeDLL);
            this.gpbCriteria.Controls.Add(this.chkFileExtension);
            this.gpbCriteria.Controls.Add(this.chkTypeEXE);
            this.gpbCriteria.Controls.Add(this.maskVersion);
            this.gpbCriteria.Controls.Add(this.chkFileVersion);
            this.gpbCriteria.Controls.Add(this.txtFileNameContain);
            this.gpbCriteria.Controls.Add(this.chkFileName);
            this.gpbCriteria.Controls.Add(this.lblSearchPath);
            this.gpbCriteria.Controls.Add(this.txtSearchPath);
            this.gpbCriteria.Location = new System.Drawing.Point(12, 7);
            this.gpbCriteria.Name = "gpbCriteria";
            this.gpbCriteria.Size = new System.Drawing.Size(572, 159);
            this.gpbCriteria.TabIndex = 2;
            this.gpbCriteria.TabStop = false;
            this.gpbCriteria.Text = "Criteria";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkTypeOCX
            // 
            this.chkTypeOCX.Enabled = false;
            this.chkTypeOCX.Location = new System.Drawing.Point(304, 101);
            this.chkTypeOCX.Name = "chkTypeOCX";
            this.chkTypeOCX.Size = new System.Drawing.Size(59, 19);
            this.chkTypeOCX.TabIndex = 9;
            this.chkTypeOCX.Text = "OCX";
            this.chkTypeOCX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTypeOCX.UseVisualStyleBackColor = true;
            // 
            // chkTypeDLL
            // 
            this.chkTypeDLL.Enabled = false;
            this.chkTypeDLL.Location = new System.Drawing.Point(237, 102);
            this.chkTypeDLL.Name = "chkTypeDLL";
            this.chkTypeDLL.Size = new System.Drawing.Size(59, 19);
            this.chkTypeDLL.TabIndex = 8;
            this.chkTypeDLL.Text = "DLL";
            this.chkTypeDLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTypeDLL.UseVisualStyleBackColor = true;
            // 
            // chkFileExtension
            // 
            this.chkFileExtension.Location = new System.Drawing.Point(29, 100);
            this.chkFileExtension.Name = "chkFileExtension";
            this.chkFileExtension.Size = new System.Drawing.Size(123, 19);
            this.chkFileExtension.TabIndex = 7;
            this.chkFileExtension.Text = "File Type: ";
            this.chkFileExtension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFileExtension.UseVisualStyleBackColor = true;
            // 
            // chkTypeEXE
            // 
            this.chkTypeEXE.Enabled = false;
            this.chkTypeEXE.Location = new System.Drawing.Point(158, 101);
            this.chkTypeEXE.Name = "chkTypeEXE";
            this.chkTypeEXE.Size = new System.Drawing.Size(59, 19);
            this.chkTypeEXE.TabIndex = 6;
            this.chkTypeEXE.Text = "EXE";
            this.chkTypeEXE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTypeEXE.UseVisualStyleBackColor = true;
            // 
            // maskVersion
            // 
            this.maskVersion.Enabled = false;
            this.maskVersion.Location = new System.Drawing.Point(158, 75);
            this.maskVersion.Mask = "0.00.0000";
            this.maskVersion.Name = "maskVersion";
            this.maskVersion.Size = new System.Drawing.Size(138, 20);
            this.maskVersion.TabIndex = 5;
            // 
            // chkFileVersion
            // 
            this.chkFileVersion.Location = new System.Drawing.Point(29, 75);
            this.chkFileVersion.Name = "chkFileVersion";
            this.chkFileVersion.Size = new System.Drawing.Size(123, 19);
            this.chkFileVersion.TabIndex = 4;
            this.chkFileVersion.Text = "Version: ";
            this.chkFileVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFileVersion.UseVisualStyleBackColor = true;
            // 
            // txtFileNameContain
            // 
            this.txtFileNameContain.Enabled = false;
            this.txtFileNameContain.Location = new System.Drawing.Point(158, 49);
            this.txtFileNameContain.Name = "txtFileNameContain";
            this.txtFileNameContain.Size = new System.Drawing.Size(388, 20);
            this.txtFileNameContain.TabIndex = 3;
            // 
            // chkFileName
            // 
            this.chkFileName.Location = new System.Drawing.Point(29, 50);
            this.chkFileName.Name = "chkFileName";
            this.chkFileName.Size = new System.Drawing.Size(123, 19);
            this.chkFileName.TabIndex = 2;
            this.chkFileName.Text = "File Name Contain: ";
            this.chkFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFileName.UseVisualStyleBackColor = true;
            // 
            // lblSearchPath
            // 
            this.lblSearchPath.AutoSize = true;
            this.lblSearchPath.Location = new System.Drawing.Point(21, 24);
            this.lblSearchPath.Name = "lblSearchPath";
            this.lblSearchPath.Size = new System.Drawing.Size(69, 13);
            this.lblSearchPath.TabIndex = 0;
            this.lblSearchPath.Text = "Search Path:";
            this.lblSearchPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearchPath
            // 
            this.txtSearchPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchPath.Enabled = false;
            this.txtSearchPath.Location = new System.Drawing.Point(93, 21);
            this.txtSearchPath.Name = "txtSearchPath";
            this.txtSearchPath.Size = new System.Drawing.Size(453, 20);
            this.txtSearchPath.TabIndex = 1;
            // 
            // FindExeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 391);
            this.Controls.Add(this.splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindExeForm";
            this.Text = "Find EXE";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitBody.Panel1.ResumeLayout(false);
            this.splitBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).EndInit();
            this.splitBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gpbCriteria.ResumeLayout(false);
            this.gpbCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Button btnSaveBasePath;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Label lblBasePath;
        private System.Windows.Forms.SplitContainer splitBody;
        private System.Windows.Forms.TreeView treeBasePath;
        private System.Windows.Forms.GroupBox gpbCriteria;
        private System.Windows.Forms.Label lblSearchPath;
        private System.Windows.Forms.TextBox txtSearchPath;
        private System.Windows.Forms.CheckBox chkTypeOCX;
        private System.Windows.Forms.CheckBox chkTypeDLL;
        private System.Windows.Forms.CheckBox chkFileExtension;
        private System.Windows.Forms.CheckBox chkTypeEXE;
        private System.Windows.Forms.MaskedTextBox maskVersion;
        private System.Windows.Forms.CheckBox chkFileVersion;
        private System.Windows.Forms.TextBox txtFileNameContain;
        private System.Windows.Forms.CheckBox chkFileName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvList;
    }
}

