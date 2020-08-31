using MediaConverter.ViewModels;
using System;
using System.Collections.Generic;
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

namespace MediaConverter.Views
{
    /// <summary>
    /// Interaktionslogik für RecoveryWindow.xaml
    /// </summary>
    public partial class RecoveryOriginalView : UserControl
    {
        public RecoveryOriginalView()
        {
            this.DataContext = new RecoveryOriginalViewModel();
            InitializeComponent();
        }
    }
}
