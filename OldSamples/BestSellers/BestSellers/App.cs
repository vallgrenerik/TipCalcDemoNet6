using BestSellers.ViewModels;
using MvvmCross.Core.ViewModels;
using System;
using MvvmCross.Platform.Core;
using MvvmCross.Platform;

namespace BestSellers
{
    public interface IErrorReporter
    {
        void ReportError(string error);
    }

    public class ErrorEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public ErrorEventArgs(string message)
        {
            Message = message;
        }
    }

    public interface IErrorSource
    {
        event EventHandler<ErrorEventArgs> ErrorReported;
    }

    public class ErrorApplicationObject
        : MvxMainThreadDispatchingObject
        , IErrorReporter
        , IErrorSource
    {
        public void ReportError(string error)
        {
            if (ErrorReported == null)
                return;

            InvokeOnMainThread(() =>
                                   {
                                       var handler = ErrorReported;
                                       if (handler != null)
                                           handler(this, new ErrorEventArgs(error));
                                   });
        }

        public event EventHandler<ErrorEventArgs> ErrorReported;
    }

    public class App
        : MvxApplication
    {
        public App()
        {
            RegisterAppStart<CategoryListViewModel>();

            var errorApplicationObject = new ErrorApplicationObject();
            Mvx.RegisterSingleton<IErrorReporter>(errorApplicationObject);
            Mvx.RegisterSingleton<IErrorSource>(errorApplicationObject);
        }
    }
}