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
