using Panacea.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
