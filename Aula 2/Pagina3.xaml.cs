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

namespace Aula_2
{
    /// <summary>
    /// Interaction logic for Pagina3.xaml
    /// </summary>
    public partial class Pagina3 : Page
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void botaoExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
