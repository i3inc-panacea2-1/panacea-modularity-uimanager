using Panacea.Mvvm;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public interface IPopupContainer
    {
        Task<TResult> ShowPopup<TResult>(
            PopupViewModelBase<TResult> element,
            string title = null,
            PopupType popupType = PopupType.None,
            bool closable = true,
            bool trasnparent = true);

        void HidePopup(ViewModelBase element);
        void HideAllPopups();
    }

    
}
