using Panacea.Core.Mvvm;
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
        void AddMainPageControl(ViewModelBase c);

        void RemoveMainPageControl(ViewModelBase c);

        void AddNavigationBarControl(ViewModelBase c);

        void RemoveNavigationBarControl(ViewModelBase c);

        void AddSettingsControl(ViewModelBase c);

        void RemoveSettingsControl(ViewModelBase c);
    }
}
