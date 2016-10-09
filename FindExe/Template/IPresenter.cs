using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Views;

namespace MVP.Presenters
{
    public delegate void VoidEventHandler();
    public interface IPresenter<V> where V : IView
    {
        V View { get; }
        void CloseView();
        void OnViewInitialize();
        void RaiseVoidEvent(VoidEventHandler @event);
        void ShowView();

        event VoidEventHandler OnCloseView;
        event VoidEventHandler OnShowView;
    }
}
