using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FindExe.Views;
using MVP.Presenters;
using Helpers.Controls;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace FindExe
{
    public partial class FindExeForm : Form, IFindExeView
    {
        //======== INTERFACE VAR ========
        public event VoidEventHandler OnViewInitialize;
        public event VoidEventHandler OnViewFinalizeClose;

        public event Action SaveBasePath;
        public event Action SelectSearchPath;
        public event Action CheckFileName;
        public event Action CheckFileVersion;
        public event Action CheckFileExtension;
        public event Action SearchFile;
        public event Action ClearUI;

        public string BasePath 
        { 
            get
            {
                string BasePath = "";
                txtBasePath.InvokeIfRequired(() => { BasePath = txtBasePath.Text; });
                return BasePath;
            }
            set
            {
                txtBasePath.InvokeIfRequired(() => {
                    txtBasePath.Text = value;
                    DirectoryInfo directoryInfo = new DirectoryInfo(value);
                    if (directoryInfo.Exists)
                    {
                        //treeView1.AfterSelect += treeView1_AfterSelect;
                        BuildTree(directoryInfo, treeBasePath.Nodes);
                    }
                });
            }
        }
        public string SelectPath 
        {
            get 
            {
                string SelectPath = "";
                treeBasePath.InvokeIfRequired(() => {
                    TreeNode node = treeBasePath.SelectedNode;
                    SelectPath = node.Name;
                });
                return SelectPath;
            }
        }
        public string SearchPath 
        {
            get
            {
                string SearchPath = "";
                txtSearchPath.InvokeIfRequired(() => { SearchPath = txtSearchPath.Text; });
                return SearchPath;
            }
            set
            {
                txtSearchPath.InvokeIfRequired(() => { txtSearchPath.Text = value; });
            }
        }
        public string SearchName 
        {
            get
            {
                string SearchName = "";
                txtFileNameContain.InvokeIfRequired(() => { SearchName = txtFileNameContain.Text; });
                return SearchName;
            }
            set
            {
                txtFileNameContain.InvokeIfRequired(() => { txtFileNameContain.Text = value; });
            }
        }
        public string SearchVersion
        {
            get
            {
                string SearchVersion = "";
                maskVersion.InvokeIfRequired(() => { SearchVersion = maskVersion.Text; });
                return SearchVersion;
            }
            set
            {
                maskVersion.InvokeIfRequired(() => { maskVersion.Text = value; });
            }
        }
        public Boolean SearchEXE 
        {
            get
            {
                Boolean SearchEXE = false;
                chkTypeEXE.InvokeIfRequired(() => { SearchEXE = chkTypeEXE.Checked; });
                return SearchEXE;
            }
            set
            {
                chkTypeEXE.InvokeIfRequired(() => { chkTypeEXE.Checked = value; });
            }
        }
        public Boolean SearchDLL
        {
            get
            {
                Boolean SearchDLL = false;
                chkTypeDLL.InvokeIfRequired(() => { SearchDLL = chkTypeDLL.Checked; });
                return SearchDLL;
            }
            set
            {
                chkTypeDLL.InvokeIfRequired(() => { chkTypeDLL.Checked = value; });
            }
        }
        public Boolean SearchOCX
        {
            get
            {
                Boolean SearchOCX = false;
                chkTypeOCX.InvokeIfRequired(() => { SearchOCX = chkTypeOCX.Checked; });
                return SearchOCX;
            }
            set
            {
                chkTypeOCX.InvokeIfRequired(() => { chkTypeOCX.Checked = value; });
            }
        }
        public Boolean SelectFileName 
        {
            get 
            {
                Boolean SelectFileName = false;
                chkFileName.InvokeIfRequired(() => { SelectFileName = chkFileName.Checked; });
                return SelectFileName;
            }
            set
            {
                chkFileName.InvokeIfRequired(() => { chkFileName.Checked = value; });
            }
        }
        public Boolean SelectFileVersion 
        {
            get 
            {
                Boolean SelectFileType = false;
                chkFileVersion.InvokeIfRequired(() => { SelectFileType = chkFileVersion.Checked; });
                return SelectFileType;
            }
            set
            {
                chkFileVersion.InvokeIfRequired(() => { chkFileVersion.Checked = value; });
            }
        }
        public Boolean SelectFileExtension 
        {
            get
            {
                Boolean SelectFileExtension = false;
                chkFileExtension.InvokeIfRequired(() => { SelectFileExtension = chkFileExtension.Checked; });
                return SelectFileExtension;
            }
            set
            {
                chkFileExtension.InvokeIfRequired(() => { chkFileExtension.Checked = value; });
            }
        }

        public Boolean EnableFileName
        {
            get
            {
                Boolean FileNameEnable = false;
                txtFileNameContain.InvokeIfRequired(() => { FileNameEnable = txtFileNameContain.Enabled; });
                return FileNameEnable;
            }
            set
            {
                txtFileNameContain.InvokeIfRequired(() => { txtFileNameContain.Enabled = value; });
            }
        }
        public Boolean EnableFileVersion
        {
            get
            {
                Boolean FileVersionEnable = false;
                maskVersion.InvokeIfRequired(() => { FileVersionEnable = maskVersion.Enabled; });
                return FileVersionEnable;
            }
            set
            {
                maskVersion.InvokeIfRequired(() => { maskVersion.Enabled = value; });
            }
        }
        public Boolean EnableFileTypeEXE 
        {
            get
            {
                Boolean FileTypeEXE = false;
                chkTypeEXE.InvokeIfRequired(() => { FileTypeEXE = chkTypeEXE.Enabled; });
                return FileTypeEXE;
            }
            set
            {
                chkTypeEXE.InvokeIfRequired(() => { chkTypeEXE.Enabled = value; });
            }
        }
        public Boolean EnableFileTypeDLL
        {
            get
            {
                Boolean FileTypeDLL = false;
                chkTypeDLL.InvokeIfRequired(() => { FileTypeDLL = chkTypeDLL.Enabled; });
                return FileTypeDLL;
            }
            set
            {
                chkTypeDLL.InvokeIfRequired(() => { chkTypeDLL.Enabled = value; });
            }
        }
        public Boolean EnableFileTypeOCX
        {
            get
            {
                Boolean FileTypeOCX = false;
                chkTypeOCX.InvokeIfRequired(() => { FileTypeOCX = chkTypeOCX.Enabled; });
                return FileTypeOCX;
            }
            set
            {
                chkTypeOCX.InvokeIfRequired(() => { chkTypeOCX.Enabled = value; });
            }
        }
        public List<Object> GridDataSource
        {
            set
            {
                if ((value != null) && (value.Count > 0))
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = value;
                    dgvList.DataSource = bindingSource;
                    //format grid
                    //Add Open button
                    if (!dgvList.Columns.Contains("Open"))
                    {
                        DataGridViewButtonColumn btnColOpen = new DataGridViewButtonColumn();
                        dgvList.Columns[0].Visible = false;
                        dgvList.Columns.Insert(0, btnColOpen);
                        btnColOpen.HeaderText = "Parent Path";
                        btnColOpen.Width = 80;
                        btnColOpen.Text = "Open";
                        btnColOpen.Name = "Open";
                        btnColOpen.UseColumnTextForButtonValue = true;
                    }
                }
                else
                {
                    dgvList.Columns.Clear();
                    dgvList.DataSource = null;
                }
            }
            get
            {
                return ((List<Object>)dgvList.DataSource).Cast<Object>().ToList();
            }
        }
        public FindExeForm()
        {
            InitializeComponent();
            btnSaveBasePath.Click += OnSaveBasePath_Click;
            treeBasePath.AfterSelect += OnTreeView_AfterSelect;
            chkFileName.Click += OnFileName_Click;
            chkFileVersion.Click += OnFileVersion_Click;
            chkFileExtension.Click += OnFileType_Click;
            btnSearch.Click += OnSearch_Click;
            btnClear.Click += OnClear_Click;
            dgvList.CellClick += OndgvList_CellClick;
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                TreeNode curNode = addInMe.Add(subdir.FullName, subdir.Name);
                //BuildTree(subdir, curNode.Nodes);
            }
        }

        private void OnSaveBasePath_Click(object sender, EventArgs e)
        {
            if (this.SaveBasePath != null)
            {
                this.SaveBasePath();
            }
        }

        private void OnTreeView_AfterSelect(object sender, EventArgs e)
        {
            if (this.SelectSearchPath != null)
            {
                this.SelectSearchPath();
            }
        }

        private void OnFileName_Click(object sender, EventArgs e)
        {
            if (this.CheckFileName != null)
            {
                this.CheckFileName();
            }
        }

        private void OnFileVersion_Click(object sender, EventArgs e)
        {
            if (this.CheckFileVersion != null)
            {
                this.CheckFileVersion();
            }
        }

        private void OnFileType_Click(object sender, EventArgs e)
        {
            if (this.CheckFileExtension != null)
            {
                this.CheckFileExtension();
            }
        }
        private void OnSearch_Click(object sender, EventArgs e)
        {
            if (this.SearchFile != null)
            {
                this.SearchFile();
            }
        }
        private void OnClear_Click(object sender, EventArgs e)
        {
            if (this.ClearUI != null)
            {
                this.ClearUI();
            }
        }

        private void OndgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Process.Start(dgvList[1, e.RowIndex].Value.ToString());
            }
        }

        public void CloseView()
        {
            throw new NotImplementedException();
        }

        public void ShowView()
        {
            this.ShowDialog();
        }
        public void RaiseVoidEvent(VoidEventHandler @event)
        {
            throw new NotImplementedException();
        }
    }
}
