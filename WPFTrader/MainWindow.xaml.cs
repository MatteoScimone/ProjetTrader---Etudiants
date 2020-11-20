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
using GestionnaireBDD;
using MetierTrader;

namespace WPFTrader
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GstBdd gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new GstBdd();
            lstTraders.ItemsSource = gst.getAllTraders();
        }

        private void lstTraders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstActions.ItemsSource = gst.getAllActionsByTrader((lstTraders.SelectedItem as Trader).NumTrader);
        }

        private void lstActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // int quantite = 0;
            //int prixAchat = 0;
           txtTotalPortefeuille.Text = Convert.ToInt16(txtTotalPortefeuille.Text).ToString();
            if (txtTotalPortefeuille!=null)
            {
              //  txtTotalPortefeuille = quantite * prixAchat;
            }

        }

        private void btnVendre_Click(object sender, RoutedEventArgs e)
        {
            if (lstActions.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un trader");
            }
            else if (txtTotalPortefeuille.Text==null)
            {
                MessageBox.Show("Veuillez sélectionner une action ");
            }
            else
            {

            }
        }

        private void btnAcheter_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrixAchat == null)
            {
                MessageBox.Show("Veuillez sélectionner un achat ");
            }
            else if (txtQuantiteAchetee==null)
            {
                MessageBox.Show("Veuillez saisir le nombre que vous voulez vendre ");
            }
            else
            {

            }
        }
    }
}
