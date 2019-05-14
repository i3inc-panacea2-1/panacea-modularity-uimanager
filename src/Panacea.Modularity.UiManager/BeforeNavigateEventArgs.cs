using Panacea.Core.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Modularity.UiManager
{
    public class BeforeNavigateEventArgs
    {
        public ViewModelBase NextPage { get; set; }
        public bool Cancel { get; set; }
        public ViewModelBase Page { get; set; }
    }
}
