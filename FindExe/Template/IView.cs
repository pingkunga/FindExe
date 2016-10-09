﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Presenters;

namespace MVP.Views
{
    public interface IView
    {
        void CloseView();
        //void SetTitle(string title);
        void ShowView();
        void RaiseVoidEvent(VoidEventHandler @event);

        event VoidEventHandler OnViewInitialize;
        event VoidEventHandler OnViewFinalizeClose;
        //event VoidEventHandler OnViewShown;
        //event VoidEventHandler OnViewClose;
    }
}
