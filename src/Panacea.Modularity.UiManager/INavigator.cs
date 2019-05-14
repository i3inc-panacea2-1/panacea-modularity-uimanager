using Panacea.Core.Mvvm;
using System;
using System.Collections.Generic;


namespace Panacea.Modularity.UiManager
{
    public interface INavigator
    {

        IReadOnlyList<ViewModelBase> History { get; }

        ViewModelBase CurrentPage { get; }

        bool IsNavigationDisabled { get; set; }

        bool IsHomeTheCurrentPage { get; }

        void Navigate(ViewModelBase page, bool cache = true);

        void GoBack(int count = 1);

        void GoHome();

        event EventHandler<BeforeNavigateEventArgs> BeforeNavigate;
        event EventHandler<BeforeNavigateEventArgs> Back;
        event EventHandler AfterNavigate;


    }
}
