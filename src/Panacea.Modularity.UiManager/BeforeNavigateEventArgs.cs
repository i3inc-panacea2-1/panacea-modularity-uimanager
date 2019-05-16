using Panacea.Mvvm;

namespace Panacea.Modularity.UiManager
{
    public class BeforeNavigateEventArgs
    {
        public ViewModelBase NextPage { get; set; }
        public bool Cancel { get; set; }
        public ViewModelBase Page { get; set; }
    }
}
