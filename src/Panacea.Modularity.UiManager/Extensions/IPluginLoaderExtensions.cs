using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.UiManager.Extensions
{
    public static class PanaceaServicesExtensions
    {
        public static IUiManagerPlugin GetUiManager(this PanaceaServices services)
        {
            return services.PluginLoader.GetPlugins<IUiManagerPlugin>().FirstOrDefault();
        }
    }
}
