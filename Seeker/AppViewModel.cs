using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using NPLib.Models;
using Seeker.ViewModels;

namespace Seeker
{
    [Export(typeof(AppViewModel))]
    public class AppViewModel : PropertyChangedBase
    {
        private IWindowManager _windowManager;

        #region Child ViewModels
        public SettingsViewModel SettingsViewModel { get; set; }
        #endregion

        #region Private Fields
        private bool _is_running = false;
        private User _current_user = new User() { is_authenticated = false };
        #endregion

        #region Getters and Setters
        public bool IsRunning
        {
            get { return _is_running; }
            set
            {
                _is_running = value;
                NotifyOfPropertyChange(() => IsRunning);
            }
        }

        public User CurrentUser
        {
            get { return _current_user; }
            set
            {
                _current_user = value;
                NotifyOfPropertyChange(() => CurrentUser);
            }
        }
        #endregion

        #region Actions
        public void OpenSettings(int _tab_index)
        {
            _windowManager.ShowDialog(SettingsViewModel);
        }
        #endregion

        [ImportingConstructor]
        public AppViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;

            // Init children view models.
            SettingsViewModel = new SettingsViewModel(_windowManager);
        }
    }
}
