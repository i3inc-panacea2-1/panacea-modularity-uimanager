using Panacea.Mvvm;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public class LiveTileFrame
    {
        public LiveTileFrame(ViewModelBase element, int interval)
        {
            Element = element;
            Interval = interval;
        }
        public ViewModelBase Element { get; }

        public int Interval { get; }

    }
}
