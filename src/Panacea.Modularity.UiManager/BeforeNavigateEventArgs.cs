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
        public FrameworkElement NextPage { get; set; }
        public bool Cancel { get; set; }
        public FrameworkElement Page { get; set; }
    }
}
