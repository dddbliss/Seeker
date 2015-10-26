using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;

namespace Seeker
{
    [Export(typeof(AppViewModel))]
    public class AppViewModel : PropertyChangedBase
    {
        private IWindowManager _windowManager;

        [ImportingConstructor]
        public AppViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }
    }
}
