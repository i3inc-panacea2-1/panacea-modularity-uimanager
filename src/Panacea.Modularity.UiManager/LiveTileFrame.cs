using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public class LiveTileFrame
    {
        public LiveTileFrame(FrameworkElement element, int interval)
        {
            Element = element;
            Interval = interval;
        }
        public FrameworkElement Element { get; }

        public int Interval { get; }

    }
}
