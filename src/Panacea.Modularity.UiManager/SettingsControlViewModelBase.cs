using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public abstract class SettingsControlViewModelBase : ViewModelBase
    {
        public event EventHandler Close;

        protected virtual void OnClose()
        {
            Close?.Invoke(this, null);
        }
    }
}
