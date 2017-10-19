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

namespace TrabalhoDeAS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Logar(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "caixa")
            {
                this.Hide();
                new TelaPrincipal().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("ID não encontrado!", "Erro!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                
        }

        private void Teste(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Logar(null, null);

        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            txtId.Focus();
        }
    }
}
