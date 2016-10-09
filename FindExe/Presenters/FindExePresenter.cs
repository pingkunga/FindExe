using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Presenters;
using MVP.Views;
using FindExe.Views;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Collections;

namespace FindExe.Presenters
{
    public class FindExePresenter : Presenter<IView>
    {
        private readonly IFindExeView findExeView;
        public FindExePresenter(IFindExeView view): base(view)
        {
            //invConfigMapper = new InvConfigMapper();
            //dbConnect = new DBConnect();
            ////Background thread
            //databaseWorker = new BackgroundWorker();
            //databaseWorker.WorkerReportsProgress = true;
            //databaseWorker.WorkerSupportsCancellation = true;
            ////Background thread
            this.findExeView = view;
            this.OnViewInitialize();
            this.ShowView();
        }

        public override void OnViewInitialize()
        {
            try
            {
                base.OnViewInitialize();
                BindEvent();
                findExeView.SelectFileName = false;
                findExeView.SelectFileVersion = false;
                findExeView.SelectFileExtension = false;
                //Get Last Config
                string BasePath = Properties.Settings.Default.BasePath;
                if (Directory.Exists(BasePath))
                {
                    findExeView.BasePath = BasePath;
                }
                else
                {
                    findExeView.BasePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
            }
            catch(ApplicationException ex)
            {
                //Load config form registry
                //if (ex.Message.Equals(Properties.Resources.ExCannotGetSpecificEnvConfig))
                //{
                //    this.ViewInvConfig = invConfigMapper.GetLocalEnviromentInvConfig();
                //    log.Warn(ex.Message);
                //}
            }
            catch(Exception ex)
            {
                //log.Error(ex.Message, ex);
            }
        }

        private void BindEvent()
        {
            findExeView.SaveBasePath += SaveBasePath;
            findExeView.SelectSearchPath += SelectSearchPath;
            findExeView.CheckFileName += CheckFileName;
            findExeView.CheckFileVersion += CheckFileVersion;
            findExeView.CheckFileExtension += CheckFileExtension;
            findExeView.SearchFile += SearchFile;
            findExeView.ClearUI += ClearUI;
        }
        private void SaveBasePath()
        {
            Properties.Settings.Default.BasePath = findExeView.BasePath;
            Properties.Settings.Default.Save();
        }
        private void SelectSearchPath()
        {
            findExeView.SearchPath = findExeView.SelectPath;
        }
        private void CheckFileName()
        {
            findExeView.EnableFileName = findExeView.SelectFileName;
            findExeView.SearchName = "";
        }
        private void CheckFileVersion()
        {
            findExeView.EnableFileVersion = findExeView.SelectFileVersion;
            findExeView.SearchVersion = "";
        }
        private void CheckFileExtension()
        {
            findExeView.EnableFileTypeEXE = findExeView.SelectFileExtension;
            findExeView.EnableFileTypeDLL = findExeView.SelectFileExtension;
            findExeView.EnableFileTypeOCX = findExeView.SelectFileExtension;
            findExeView.SearchEXE = false;
            findExeView.SearchDLL = false;
            findExeView.SearchOCX = false;
        }
        private void SearchFile()
        {
            //สร้าง Instance ของ PowerShell Class
            using (PowerShell powershell = PowerShell.Create())
            {
                /*
                 * ======= POWER SHELL SCRIPT =======
                 * 
                 * $searchDataArr = Get-ChildItem $filePath -recurse -Include *.exe, *.ocx, *.dll -ErrorAction Stop |
                 *                  Where-Object {(($_.VersionInfo).FileVersion -eq $fileVersion) -or ($_.Name -like '*'+$fileName+'*')} |                 
                 *                  Select-Object -ExpandProperty VersionInfo |
                 *                  Select-Object -Property @{l='ParentPath';e={Split-Path $_.FileName}},FileName, FileVersion, Productversion, ProductName
                 * 
                 * ======= POWER SHELL SCRIPT =======
                 */
                string extension = "";
                if (findExeView.SearchEXE)
                {
                    extension = extension + "*.exe_";
                }

                if (findExeView.SearchOCX)
                {
                    extension = extension + "*.ocx_";
                }

                if (findExeView.SearchDLL)
                {
                    extension = extension + "*.dll";
                }
                extension = extension.Replace('_', ',');
                extension = extension.TrimEnd(',');
                string script = "";
                script = script + "Get-ChildItem '" + findExeView.SearchPath + "' -recurse -Include " + extension + " -ErrorAction Stop | ";
                if (findExeView.SelectFileName || findExeView.SelectFileVersion)
                {
                    script = script + "Where-Object { ";
                    if (findExeView.SelectFileVersion)
                    {
                        script = script + "(($_.VersionInfo).FileVersion -eq '" + findExeView.SearchVersion + "')";
                        if (findExeView.SelectFileName)
                        {
                            script = script + " -or ";
                        }
                    }
                    
                    if (findExeView.SelectFileName)
                    {
                        script = script + " ( $_.Name -like '*" + findExeView.SearchName + "*') ";
                    }
                    script = script + "} | ";
                }
                script = script + "Select-Object -ExpandProperty VersionInfo | ";
                script = script + "Select-Object -Property @{l='ParentPath';e={Split-Path $_.FileName}},FileName, FileVersion, Productversion, ProductName";
                
                //เพิ่ม Script ให้กับตัวแปร PowerShell
                powershell.AddScript(script);
                if (Runspace.DefaultRunspace == null)
                {
                    //เริ่มการทำงาน
                    Runspace.DefaultRunspace = powershell.Runspace;
                }

                //ดึงผลลัพธ์กลับมาในรูปแบบของ Collection
                Collection<PSObject> results = powershell.Invoke();

                //สร้าง List มารองรับ
                List<Object> objects = new List<Object>();
                //ใส่ Result เข้าไปใน List ที่เพิ่งสร้าง
                objects.AddRange(results);
                //ส่งไปแสดงผลลัพธ์บน Grid
                findExeView.GridDataSource = objects;
            }
        }
        private void ClearUI()
        {
            findExeView.SearchPath = "";
            findExeView.SelectFileName = false;
            findExeView.SelectFileVersion = false;
            findExeView.SelectFileExtension = false;
            findExeView.GridDataSource = null;
            CheckFileName();
            CheckFileVersion();
            CheckFileExtension();
        }
    }
}
