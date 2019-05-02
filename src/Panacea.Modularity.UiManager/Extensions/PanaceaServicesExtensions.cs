using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.UiManager.Extensions
{
    public static class PanaceaServicesExtensions
    {
        public static IUiManager GetUiManager(this PanaceaServices services)
        {
            return services.PluginLoader.GetPlugin<IUiManagerPlugin>().GetUiManager();
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
