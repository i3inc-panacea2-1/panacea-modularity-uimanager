using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Panacea.Modularity.UiManager
{
    public interface IContentPage
    {
        event EventHandler<NavigateEventArgs> Navigate;
    }

    public abstract class ContentPageBase : UserControl, IContentPage
    {
        public event EventHandler<NavigateEventArgs> Navigate;
        protected void OnNavigate(IContentPage page, bool cache = true)
        {
            Navigate?.Invoke(this, new NavigateEventArgs(page, cache));
        }
    }

    public sealed class NavigateEventArgs : EventArgs
    {
        public NavigateEventArgs(IContentPage page, bool cache = true)
        {
            Page = page;
            Cache = cache;
        }

        public IContentPage Page { get; private set; }
        public bool Cache { get; private set; }
    }
}
