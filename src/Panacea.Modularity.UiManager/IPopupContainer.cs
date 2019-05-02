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
        IPopup ShowPopup(
            FrameworkElement element,
            string title = null,
            PopupType popupType = PopupType.None,
            bool closable = true,
            bool trasnparent = true);

        void HidePopup(IPopup element);
        void HidePopup(object element);
        void HideAllPopups();
    }
}
