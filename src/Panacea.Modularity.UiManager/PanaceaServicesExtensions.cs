using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public static class PanaceaServicesExtensions
    {
        public static IUiManager GetUiManager(this PanaceaServices services)
        {
            return services.PluginLoader.GetPlugin<IUiManagerPlugin>().GetUiManager();
        }

        public static bool TryGetUiManager(this PanaceaServices services, out IUiManager manager)
        {
            manager = null;
            var plugin = services.PluginLoader.GetPlugins<IUiManagerPlugin>().FirstOrDefault();
            if (plugin == null)
            {
                return false;
            }
            manager = plugin.GetUiManager();
            return true;
        }

        public static IUiManagerProvider GetUiManagerPluginProvider(this PanaceaServices services)
        {
            return new UiManagerProvider(services);
        }

        class UiManagerProvider : IUiManagerProvider
        {
            private readonly PanaceaServices _services;

            public UiManagerProvider(PanaceaServices services)
            {
                _services = services;
            }

            public IUiManager GetUiManager()
            {
                return _services.GetUiManager();
            }
        }
    }
}
