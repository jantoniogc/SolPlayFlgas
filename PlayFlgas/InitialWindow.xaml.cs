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
using System.Windows.Shapes;

namespace PlayFlgas
{
    /// <summary>
    /// Lógica de interacción para InitialWindows.xaml
    /// </summary>
    public partial class InitialWindows : Window
    {
        public InitialWindows()
        {
            InitializeComponent();
        }

        private void btjugar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }
    }
}
