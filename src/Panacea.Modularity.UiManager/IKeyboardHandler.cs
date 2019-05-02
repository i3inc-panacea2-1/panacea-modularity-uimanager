using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public interface IKeyboardHandler
    {
        void ShowKeyboard(KeyboardTypes keyboardType = KeyboardTypes.Normal);

        void HideKeyboard();
    }
}
