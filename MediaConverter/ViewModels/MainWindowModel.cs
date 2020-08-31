using MediaConverter.Helper;
using MediaConverter.Models;
using MediaConverter.ViewModels;
using MediaConverter.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MediaConverter
{
    public class MainWindowModel
    {
        #region Locals
        string selection { get; set; }
        #endregion Locals

        #region Events

        #endregion Events

        #region Constructor
        public MainWindowModel()
        {
            //Selections the user can choose (recover, convert, check or read logfile) in a treeview
            //Auswahl, die der Nutzer wählen kann, dargestellt als Baum

            TreeList = new List<Tree>();
            //Treenode recover and repair   //Zweig wiederherstellen und reparieren
            Tree recover = new Tree() { Image = "/Images/wartungIcon16px.png", HeadLine = "Wiederherstellen und reparieren" };     //Headlines of the treenodes 
            recover.Nodes.Add(new TreeNode() { Select = "Original wiederherstellen"});         //Treenodes (subselections to click)
            recover.Nodes.Add(new TreeNode() { Select = "Belegseiten reparieren" });
            TreeList.Add(recover);

            //Treenode convert file         //Zweig konvertieren
            Tree convert = new Tree() { Image = "/Images/konverterIcon16px.png", HeadLine = "Konvertieren" };
            convert.Nodes.Add(new TreeNode() { Select = "mit DB-Eintrag" });
            convert.Nodes.Add(new TreeNode() { Select = "ohne DB-Eintrag" });
            TreeList.Add(convert);

            //Treenode check file           //Zweig prüfen
            Tree check = new Tree() { Image = "/Images/ablageCodeIcon16px.png", HeadLine = "Ablagecode prüfen" };
            check.Nodes.Add(new TreeNode() { Select = "für Original" });
            check.Nodes.Add(new TreeNode() { Select = "ohne Original" });
            TreeList.Add(check);

            //Treenode logfile              //Zweig Ereignisprotokoll
            Tree log = new Tree() { Image = "/Images/logData16px.png", HeadLine = "Ereignisprotokoll" };
            log.Nodes.Add(new TreeNode() { Select = "Logfile ansehen" });
            TreeList.Add(log);
        }

        #endregion Constructor

        #region Properties
        public RecoveryOriginalView UserControl { get; set; }
        
        public List<Tree> TreeList { get; set; }
        public ObservableCollection<TreeNode> Nodes { get; set; }
        
        #endregion Properties

        #region Commands
        //command for the Selection if the user wants to recover, convert or check the files
        //command für die Auswahl, ob der User wiederherstellen, konvertieren oder prüfen will
        private ICommand _ClickSelect;
        public ICommand ClickSelect
        {
            get
            {          
                return _ClickSelect ?? (_ClickSelect = new RelayCommand<object>(x => { LoadUserControl(); }));
            }
        }
        #endregion Commands

        #region Methods
        //Stringcompare of "select" to load the needed usercontrol
        //Stringabgleich von "select" (Auswahl), der dann dem Content Binding sagt, welche Usercontrol geladen wird
        private void LoadUserControl()
        {
            //Hier folgt der Eventteil des ChildViewModels
            //der MainViewModelanteil kommt in RecoveryOriginalView.xaml.cs und dort wird die LoadMethode angesprochen.
            //Keine Ahnung, ob es funktioniert, aber ein Event ist grad das einzige, was mir einfällt, um eine Methode 
            //in einer anderen Klasse anzusprechen
            
            //selection = TreeList[0].Nodes[0].Select.ToString();
            UserControl = new RecoveryOriginalView();
            
            //MessageBox.Show(selection);
        }           
            #endregion Methods

            #region Eventhandler

            #endregion Eventhandler
        
    }
} 
            //RecoveryOriginalView recoveryOriginalView = new RecoveryOriginalView();
            //Test für Commandfunktionalität           
            //$Übergabe von select an Content$      
            //switch (Selection)
            //{
            //    case "Original wiederherstellen"://CurrentView.LoadUserControl();
                   // MessageBox.Show("");
            //        break;
            //}