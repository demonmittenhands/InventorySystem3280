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

namespace RecreationOutlet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Search searchscreen;
        Inventory inventoryscreen;

        public MainWindow()
        {
            InitializeComponent();

            searchscreen = new Search();
            inventoryscreen = new Inventory();
        }

        /// <summary>
        /// This grabs the user selection of the search/inventory combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seach_defcmbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string that holds the item from the combo box
            string option;
            option = ((ComboBoxItem)this.seach_defcmbo.SelectedItem).Content.ToString();
            //if user selects Search, show the Search screen otherwise, show the inventory screen
            if (option == "Search")
            {
                //open a search screen
                searchscreen.ShowDialog();
                this.Show();
            } else
            {
                //open an inventory screen
                inventoryscreen.ShowDialog();
                this.Show();
            }
        }
    }
}
