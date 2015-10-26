using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;

namespace Seeker.ViewModels
{
    [Export(typeof(SettingsViewModel))]
    public class SettingsViewModel : PropertyChangedBase
    {
        private IWindowManager _windowManager { get; set; }

        [ImportingConstructor]
        public SettingsViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }
    }
}
