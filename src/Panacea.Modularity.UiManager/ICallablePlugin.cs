using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public interface ICallablePlugin:IPlugin
    {
        void Call();
    }
}
