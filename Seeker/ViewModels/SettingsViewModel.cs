using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using MahApps.Metro;

namespace Seeker.ViewModels
{
    [Export(typeof(SettingsViewModel))]
    public class SettingsViewModel : Screen
    {
        private IWindowManager _windowManager { get; set; }

        private int _activeTabIndex = 0;

        public Dictionary<string, string> AccentList
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "Red", "Red" },
                    { "Green","Green" },
                    { "Blue", "Blue" },
                    { "Purple", "Purple" },
                    { "Orange", "Orange" },
                    { "Lime", "Lime" },
                    { "Emerald", "Emerald" },
                    { "Teal", "Teal" },
                    { "Cyan", "Cyan" },
                    { "Cobalt", "Cobalt" },
                    { "Indigo", "Indigo" },
                    { "Violet", "Violet" },
                    { "Pink", "Pink" },
                    { "Magenta", "Magenta" },
                    { "Crimson", "Crimson" },
                    { "Amber", "Amber" },
                    { "Yellow", "Yellow" },
                    { "Brown", "Brown" },
                    { "Olive", "Olive" },
                    { "Steel", "Steel" },
                    { "Mauve", "Mauve" },
                    { "Taupe", "Taupe" },
                    { "Sienna", "Sienna" }
                };
            }
        }

        public int ActiveTabIndex
        {
            get
            {
                return _activeTabIndex;
            }
            set
            {
                _activeTabIndex = value;
                NotifyOfPropertyChange(() => ActiveTabIndex);
            }
        }

        public string Password { get; set; }
        public string ProxyPassword { get; set; }


        [ImportingConstructor]
        public SettingsViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public void Save()
        {
            Properties.Settings.Default.Login_Password = Password;
            Properties.Settings.Default.Web_ProxyPassword = ProxyPassword;
            Properties.Settings.Default.Save();

            ThemeManager.ChangeAppStyle(App.Current,
                                       ThemeManager.GetAccent(Properties.Settings.Default.UI_Accent),
                                       ThemeManager.GetAppTheme("BaseLight"));

            TryClose();
        }

        public void Cancel()
        {
            TryClose();
        }

    }
}
