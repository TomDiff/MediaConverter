using MediaConverter.Helper;
using MediaConverter.Models;
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
            List<Tree> treeList = new List<Tree>();
            //Zweig Wiederherstellen und reparieren 
            Tree recover = new Tree() { Headline = "Wiederherstellen und reparieren" };     //Überschrift des Zweiges
            recover.Nodes.Add(new TreeNode() { Select = "Original wiederherstellen" });         // Unterkategorie (Auswahl zum anklicken)
            recover.Nodes.Add(new TreeNode() { Select = "Belegseiten reparieren" });
            treeList.Add(recover);

            //Zweig Konvertieren
            Tree convert = new Tree() { Headline = "Konvertieren" };
            convert.Nodes.Add(new TreeNode() { Select = "mit DB-Eintrag" });
            convert.Nodes.Add(new TreeNode() { Select = "mit DB-Eintrag" });
            treeList.Add(convert);

            //Zweig Ablagecode prüfen
            Tree check = new Tree() { Headline = "Ablagecode prüfen" };
            check.Nodes.Add(new TreeNode() { Select = "für Original" });
            check.Nodes.Add(new TreeNode() { Select = "ohne Original" });
            treeList.Add(check);

            //Zweig Ereignisprotokoll
            Tree log = new Tree() { Headline = "Ereignisprotokoll" };
            treeList.Add(log);

            // NameDesTreeViews.ItemsSource =  treeList
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
