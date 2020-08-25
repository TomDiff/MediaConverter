using MediaConverter.Helper;
using MediaConverter.ViewModels;
using MediaConverter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MediaConverter
{
    public class MainWindowModel
    {
        #region Locals

        #endregion Locals

        #region Events

        #endregion Events

        #region Constructor
        public MainWindowModel()
        {

        }
        #endregion Constructor

        #region Properties
        public RecoveryOriginalView _currentView { get; set; }
        
        #endregion Properties

        #region Commands
        private ICommand _ClickRecoveryOriginal;
        public ICommand ClickRecoveryOriginal
        {
            get
            {
                return _ClickRecoveryOriginal ?? (_ClickRecoveryOriginal = new RelayCommand<object>(x => { LoadUserControl(); }));
            }
        }
        #endregion Commands

        #region Methods
        private void LoadUserControl()
        {
            

          
             MessageBox.Show("Hello");

        }
        #endregion Methods

        #region Eventhandler

        #endregion Eventhandler
    }
}
