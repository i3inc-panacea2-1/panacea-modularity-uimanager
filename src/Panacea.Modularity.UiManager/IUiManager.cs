using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public interface IUiManager :
        INavigator, 
        INotifier, 
        IPopupContainer,
        ICustomizable,
        IKeyboardHandler
    {
        void EnableFullscreen();

        void DisableFullscreen();

        bool IsPaused { get; }

        event EventHandler Paused;

        event EventHandler Resumed;

        void Pause();

        void Resume();

        Task<byte[]> DownloadDataAsync(string url);

        Task DoWhileBusy(Func<Task> action);

        Task<TResult> DoWhileBusy<TResult>(Func<Task<TResult>> action);

        void Restart(string message, Exception exception = null);

    }
}
