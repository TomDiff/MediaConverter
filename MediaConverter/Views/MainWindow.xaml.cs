using MediaConverter.ViewModels;
using MediaConverter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaConverter
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowModel();
          //  InitializeComponent();
        }
    }
}


//public MainWindow()
//{
//    DataContext = new MainWindowModel();
//    InitializeComponent();
//}
//      RecoveryOriginalView _recoveryOriginalView = new RecoveryOriginalViewModel();

//
//      private void button1_Click(object sender, RoutedEventArgs e)
//      {
//      ContainerView.Child = _recoveryWindow;
//      }
//   }