using Panacea.Mvvm;

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
