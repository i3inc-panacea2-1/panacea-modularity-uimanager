using Panacea.Mvvm;
using System;


namespace Panacea.Modularity.UiManager
{
    public interface INotifier
    {
        /// <summary>
        ///     Show a notification.
        /// </summary>
        /// <param name="message">The message to be shown.</param>
        /// <param name="del">A callback to be called when the user clicks this notification</param>
        /// <returns></returns>
        void Notify(string message, Action del);

        /// <summary>
        ///     Show a notification.
        /// </summary>
        /// <param name="c">A custom control to be displayed.</param>
        void Notify(ViewModelBase c);

        /// <summary>
        ///     Remove a notification.
        /// </summary>
        /// <param name="c"></param>
        void Refrain(ViewModelBase c);

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
    }
}
