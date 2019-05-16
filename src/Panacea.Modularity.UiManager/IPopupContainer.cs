using Panacea.Mvvm;

namespace Panacea.Modularity.UiManager
{
    public interface IPopupContainer
    {
        void ShowPopup(
            ViewModelBase element,
            string title = null,
            PopupType popupType = PopupType.None,
            bool closable = true,
            bool trasnparent = true);

        void HidePopup(ViewModelBase element);
        void HideAllPopups();
    }

    
}
