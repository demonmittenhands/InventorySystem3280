using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace RecreationOutlet
{
    public static class testSearch
    {
        public static ObservableCollection<cls_Invoice> GetData()
        {
            ObservableCollection<cls_Invoice> list = new ObservableCollection<cls_Invoice>();

            cls_Customer customer = new cls_Customer("Bob", 27);
            cls_Product product = new cls_Product(14, "Bike", 85.63);
            DateTime date = new DateTime(2015,12,1);
            cls_Invoice invoice = new cls_Invoice(1,customer, product, date);

            list.Add(invoice);

            customer = new cls_Customer("Tom", 85);
            product = new cls_Product(10, "Snowboard", 105.99);
            date = new DateTime(2015, 11, 30);
            invoice = new cls_Invoice(2, customer, product, date);

            list.Add(invoice);

            customer = new cls_Customer("Jared", 10);
            product = new cls_Product(17, "Kyak", 242.13);
            date = new DateTime(2015, 11, 22);
            invoice = new cls_Invoice(3, customer, product, date);

            list.Add(invoice);

            return list;
        }
    }
}
