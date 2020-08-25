using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ICommand DoubleClickCommand
        {
            get
            {
                return _doubleClickCommand ?? (_doubleClickCommand = new RelayCommand<object>(x => { EditSelectedCharakter(); }));
            }
        }
        #endregion Commands
        #region Methods

        #endregion Methods
        #region Eventhandler

        #endregion Eventhandler
    }
}
