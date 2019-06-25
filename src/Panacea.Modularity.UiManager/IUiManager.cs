using System;
using System.Threading.Tasks;
using System.Windows.Input;

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

        event KeyEventHandler PreviewKeyDown;

        event KeyEventHandler PreviewKeyUp;

    }
}
