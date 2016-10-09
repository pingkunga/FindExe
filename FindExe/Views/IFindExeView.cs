using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Views;
using System.Collections;

namespace FindExe.Views
{
    public interface IFindExeView : IView
    {
        #region =======EVENT SECTION======
        event Action SaveBasePath;
        event Action SelectSearchPath;
        event Action CheckFileName;
        event Action CheckFileVersion;
        event Action CheckFileExtension;
        event Action SearchFile;
        event Action ClearUI;
        #endregion ====EVENT SECTION======

        #region =====PROPERTY SECTION=====
        string BasePath { get; set; }
        string SelectPath { get; }
        string SearchPath { get; set; }
        string SearchName { get; set; }
        string SearchVersion { get; set; }
        Boolean SearchEXE { get; set; }
        Boolean SearchDLL { get; set; }
        Boolean SearchOCX { get; set; }
        Boolean SelectFileName { get; set; }
        Boolean SelectFileVersion { get; set; }
        Boolean SelectFileExtension { get; set; }
        //UI Enable
        //http://thedersen.com/blog/2010/01/15/passive-view-the-way-we-do-it/
        Boolean EnableFileName { get; set; }
        Boolean EnableFileVersion { get; set; }
        Boolean EnableFileTypeEXE { get; set; }
        Boolean EnableFileTypeDLL { get; set; }
        Boolean EnableFileTypeOCX { get; set; }
        List<Object> GridDataSource { get; set; }
        #endregion ==PROPERTY SECTION=====

     
    }
}
