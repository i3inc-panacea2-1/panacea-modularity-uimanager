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
        void AddMainPageControl(FrameworkElement c);

        void RemoveMainPageControl(FrameworkElement c);

        void AddNavigationBarControl(FrameworkElement c);

        void RemoveNavigationBarControl(FrameworkElement c);

        void AddSettingsControl(FrameworkElement c);

        void RemoveSettingsControl(FrameworkElement c);
    }
}
