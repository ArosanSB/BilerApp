using BusniessLogic.BLL;
using DTO.Model;
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
using WpfBiler.Windows;

namespace WpfBiler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BilBLL controller = new BilBLL();
        public MainWindow()
        {
            InitializeComponent();
            updateListView();
           
            
         }

        private void updateListView()
        {
            listView_Biler.ItemsSource = controller.getAllCars();
        }

        private void CreateHandler(object sender, RoutedEventArgs e)
        {
            FormWindow window = new FormWindow();
            window.ShowDialog();

            if ((bool)window.DialogResult)
            {
                controller.AddCar(window.bil);
                MessageBox.Show("Bil oprettet!");
                updateListView();
            }

        }

        private void UpdateHandler(object sender, RoutedEventArgs e)
        {
            BilDTO car = (BilDTO)this.listView_Biler.SelectedItem;
            int index = this.listView_Biler.SelectedIndex;

            if (car == null)
            {
                MessageBox.Show("Vælg en bil fra listen som skal opdateres");
                return;
            }

            FormWindow window = new FormWindow(car);
            window.ShowDialog();

            if ((bool)window.DialogResult)
            {
                controller.UpdateCar(window.bil);
                MessageBox.Show("Bilem er Opdateret!");
                updateListView();
                this.listView_Biler.SelectedIndex = index;
            }

        }

        private void DeleteHandler(object sender, RoutedEventArgs e)
        {
            BilDTO car = (BilDTO) this.listView_Biler.SelectedItem;

            if (car == null)
            {
                MessageBox.Show("Vælg en bil fra listen");
                return;
            }

            controller.DeleteCar(car.RegNr);
            MessageBox.Show("Bilen er slettet!");
            updateListView();
            this.listView_Biler.SelectedIndex = 0;



        }

        private void btn_UpdateList_Click(object sender, RoutedEventArgs e)
        {
            updateListView();
        }

       
    }
}
