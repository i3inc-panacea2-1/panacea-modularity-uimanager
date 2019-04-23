using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public interface IPopup
    {
        bool Closable { get; set; }

        string Title { get; set; }

        FrameworkElement PopupContent { get; set; }

        PopupType PopupType { get; set; }

        event EventHandler Closed;

        void Close();
    }
}
