using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public interface IUiManagerPlugin : IPlugin
    {
        void AddToolButton(string text, string namesp, string iconUrl, Action action);

        void EnableFullscreen();

        void DisableFullscreen();

        #region Notifications
        /// <summary>
        ///     Show a notification.
        /// </summary>
        /// <param name="message">The message to be shown.</param>
        /// <param name="del">A callback to be called when the user clicks this notification</param>
        /// <returns></returns>
        FrameworkElement Notify(string message, Action del);

        /// <summary>
        ///     Show a notification.
        /// </summary>
        /// <param name="c">A custom control to be displayed.</param>
        void Notify(FrameworkElement c);

        /// <summary>
        ///     Remove a notification.
        /// </summary>
        /// <param name="c"></param>
        void Refrain(FrameworkElement c);

        /// <summary>
        ///     Show the notifications popup.
        /// </summary>
        void ShowNotifications();

        void HideNotifications();

        /// <summary>
        /// Shows a toast
        /// </summary>
        /// <param name="text">Text to show</param>
        /// <param name="timeout">Timeout in ms.</param>
        void Toast(string text, int timeout = 5000);
        #endregion Notifications

        #region Navigation
        IReadOnlyList<FrameworkElement> History { get; }

        FrameworkElement CurrentPage { get; }

        bool IsNavigationDisabled { get; set; }

        bool IsHomeTheCurrentPage { get; }

        void Navigate(FrameworkElement page, bool cache = true);

        void GoBack(int count = 1);

        void GoHome();

        event EventHandler<BeforeNavigateEventArgs> BeforeNavigate;
        event EventHandler<BeforeNavigateEventArgs> Back;
        event EventHandler AfterNavigate;

        #endregion Navigation

        #region Home Customizations

        /// <summary>
        ///     Sets a UIElement to be displayed in the NavigationBar on the main menu <b>only</b>.
        /// </summary>
        /// <param name="c"></param>
        void SetNavigationBarControl(FrameworkElement c);
        #endregion

        #region Keyboard
        void ShowKeyboard(KeyboardTypes keyboardType = KeyboardTypes.Normal);

        void HideKeyboard();
        #endregion

        #region Popups
        IPopup ShowPopup(
            FrameworkElement element,
            string title = null,
            PopupType popupType = PopupType.None,
            bool closable = true,
            bool trasnparent = true);

        void HidePopup(IPopup element);
        void HidePopup(object element);
        void HideAllPopups();
        #endregion Popups

        #region Pause/Resume
        bool IsPaused { get; }
        event EventHandler Paused;
        event EventHandler Resumed;
        void Pause();
        void Resume();
        #endregion  

        void RequestMagicPin();

        Task<byte[]> DownloadDataAsync(string url);

        Task DoWhileBusy(Func<Task> action);

        Task<TResult> DoWhileBusy<TResult>(Func<Task<TResult>> action);

        void Restart(string message, Exception exception = null);

        Task<bool> RequestLogin(string text);
    }
}
