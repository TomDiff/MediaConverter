using MediaConverter.Helper;
using MediaConverter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #endregion Properties
        #region Commands
        private ICommand _doubleClickRecoveryOriginal;
        public ICommand DoubleClickRecoveryOriginal
        {
            get
            {
                return _doubleClickRecoveryOriginal ?? (_doubleClickRecoveryOriginal = new RelayCommand<object>(x => { OpenRecoveryOriginalView(); }));
            }
        }
        #endregion Commands
        #region Methods
        private void OpenRecoveryOriginalView()
        {
           // ContainerView.Child = _recoveryWindow;
        }
        #endregion Methods
        #region Eventhandler

        #endregion Eventhandler
    }
}
