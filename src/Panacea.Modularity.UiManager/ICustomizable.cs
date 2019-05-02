using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public interface ICustomizable
    {
        object AddToolButton(string text, string namesp, string iconUrl, Action action);

        void RemoveToolButton(object button);
        /// <summary>
        ///     Sets a UIElement to be displayed in the NavigationBar on the main menu <b>only</b>.
        /// </summary>
        /// <param name="c"></param>
        void SetNavigationBarControl(FrameworkElement c);

        void RemoveNavigationBarControl(FrameworkElement c);
    }
}
