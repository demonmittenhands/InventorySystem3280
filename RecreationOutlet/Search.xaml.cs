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
using System.Collections.ObjectModel;

namespace RecreationOutlet
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        ObservableCollection<cls_Invoice> InvoiceList;
        ObservableCollection<cls_Invoice> InvoiceList2;
        public Search()
        {
            InitializeComponent();

            //MAKE SURE TO INCLUDE THIS LINE OR THE APPLICATION WILL NOT CLOSE
            //BECAUSE THE WINDOWS ARE STILL IN MEMORY
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            InvoiceList = testSearch.GetData();
            cbo_InvoiceNum.ItemsSource = InvoiceList;

            InvoiceList2 = testSearch.GetData();
            dg_SearchResults.ItemsSource = InvoiceList2;

            
        }
    }
}
