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

namespace PlayFlgas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void PlayFlags_Loaded(object sender, RoutedEventArgs e)
        {
            PlayFlgas.paisesDataSet paisesDataSet = ((PlayFlgas.paisesDataSet)(this.FindResource("paisesDataSet")));
            // Cargar datos en la tabla paises. Puede modificar este código según sea necesario.
            PlayFlgas.paisesDataSetTableAdapters.paisesTableAdapter paisesDataSetpaisesTableAdapter = new PlayFlgas.paisesDataSetTableAdapters.paisesTableAdapter();
            paisesDataSetpaisesTableAdapter.Fill(paisesDataSet.paises);
            System.Windows.Data.CollectionViewSource paisesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("paisesViewSource")));
            paisesViewSource.View.MoveCurrentToFirst();
            // Cargar datos en la tabla idiomas. Puede modificar este código según sea necesario.
            PlayFlgas.paisesDataSetTableAdapters.idiomasTableAdapter paisesDataSetidiomasTableAdapter = new PlayFlgas.paisesDataSetTableAdapters.idiomasTableAdapter();
            paisesDataSetidiomasTableAdapter.Fill(paisesDataSet.idiomas);
            System.Windows.Data.CollectionViewSource idiomasViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("idiomasViewSource")));
            idiomasViewSource.View.MoveCurrentToFirst();
        }
    }
}
