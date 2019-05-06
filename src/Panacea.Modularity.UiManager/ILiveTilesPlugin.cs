using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{

    public interface ILiveTilesPlugin : IPlugin
    {
        ObservableCollection<LiveTileFrame> Frames { get; }
    }

}
