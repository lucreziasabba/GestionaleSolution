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
using System.IO;

namespace WpfGestionale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  
    {

        private const string file = "Oggetti.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter xoggetti = new StreamWriter(file, true))
            {
                string oggetto = txtOggetto.Text;
                string prezzo = txtPrezzo.Text;
                xoggetti.WriteLine($"{oggetto}  {prezzo} €");
            }
        }

        private void btnVediLista_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader rdfile = new StreamReader(file))
            {
                string sline;
                while ((sline = rdfile.ReadLine()) != null)
                {
                    lstOggetti.Items.Add(sline.ToString());
                }
            }
        }
    }
}
