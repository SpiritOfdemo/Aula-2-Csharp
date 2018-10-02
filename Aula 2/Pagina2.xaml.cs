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
using System.IO;

namespace Aula_2
{
    /// <summary>
    /// Interaction logic for Pagina2.xaml
    /// </summary>
    public partial class Pagina2 : Page
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void BotaoNext_Click(object sender, RoutedEventArgs e)
        {
            string LocalSave = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Dados.txt");

            string nome = Nome.Text;
            string idade = Idade.Text;
            string cep = CEP.Text;
            string etnia = Etnia.Text;

            File.AppendAllText(LocalSave, nome + Environment.NewLine);
            File.AppendAllText(LocalSave, idade + Environment.NewLine);
            File.AppendAllText(LocalSave, cep + Environment.NewLine);
            File.AppendAllText(LocalSave, etnia + Environment.NewLine);

            Application.Current.MainWindow.Content = new Pagina3();



        }

        private void BotaoBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Pagina1();
        }
    }
}
