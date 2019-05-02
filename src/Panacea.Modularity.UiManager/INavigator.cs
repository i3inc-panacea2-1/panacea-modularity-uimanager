using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public interface INavigator
    {

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


    }
}
