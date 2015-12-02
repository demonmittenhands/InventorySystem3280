using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace RecreationOutlet
{
    /// <summary>
    /// Creates an invoice containing a customer and list of one or more products
    /// </summary>
    public class cls_Invoice : INotifyPropertyChanged
    {
        #region CLASS VARIABLES/PROPERTIES

        /// <summary>
        /// Used for notifying databindings of changes in the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// date invoice was created
        /// </summary>
        private DateTime date;        

        /// <summary>
        /// Customer who purchased the items
        /// </summary>
        private cls_Customer customer;

        /// <summary>
        /// List of the products purchased in the invoice
        /// </summary>
        private List<cls_Product> productList;

        /// <summary>
        /// Local Invoice Id
        /// </summary>
        private int i_invId;

        /// <summary>
        /// Date Invoice was created
        /// </summary>
        public DateTime Date
        {
            get
            {
                try
                {
                    return date;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
            set
            {
                try
                {
                    date = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Invoice Id
        /// </summary>
        public int InvoiceId
        {
            get
            {
                try
                {
                    return i_invId;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
            set
            {
                try
                {
                    i_invId = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("InvoiceId"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// The List of products in the invoice
        /// </summary>
        public List<cls_Product> Products
        {
            get
            {
                try
                {
                    return productList;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        public cls_Customer Customer
        {
            get
            {
                try
                {
                    return customer;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Adds the price of all of the products in the Invoice
        /// </summary>
        /// <returns>Total amount of invoice</returns>
        public double TotalCost
        {
            get
            {
                try
                {
                    double total = 0;
                    foreach (cls_Product item in productList)
                    {
                        total += item.Price;
                    }
                    return total;
                }
                catch (Exception ex)
                {
                    //Just throw the exception
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                        MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructs an invoice with just one item
        /// </summary>
        /// <param name="cust">Customer</param>
        /// <param name="prod">Product Purchased</param>
        public cls_Invoice(int id, cls_Customer cust, cls_Product prod, DateTime d)
        {
            try
            {
                i_invId = id;
                customer = cust;
                productList = new List<cls_Product>();
                productList.Add(prod);
                date = d;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }            
        }

        /// <summary>
        /// Constructs an invoice with multiple products
        /// </summary>
        /// <param name="cus">Customer</param>
        /// <param name="prodList">List of Products Purchased</param>
        public cls_Invoice(int id, cls_Customer cust, List<cls_Product> prodList, DateTime d)
        {
            try
            {
                i_invId = id;
                customer = cust;
                productList = prodList;
                date = d;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Constructs an invoice with no products
        /// </summary>
        /// <param name="cust">Customer</param>
        public cls_Invoice(int id, cls_Customer cust, DateTime d)
        {
            try
            {
                i_invId = id;
                customer = cust;
                productList = new List<cls_Product>();
                date = d;
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #endregion

        #region ADD/REMOVE PRODUCTS
        /// <summary>
        /// Add an individual product to the invoice
        /// </summary>
        /// <param name="prod">Product to be added</param>
        public void AddProduct(cls_Product prod)
        {
            try
            {
                productList.Add(prod);

                //to notify the databinding of a change
                PropertyChanged(this, new PropertyChangedEventArgs("TotalCost"));
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Add a list of products to the invoice
        /// </summary>
        /// <param name="prodList">List of Products to be added</param>
        public void AddProduct(List<cls_Product> prodList)
        {
            try
            {
                foreach (cls_Product prod in prodList)
                {
                    AddProduct(prod);
                }
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Removes a product from the invoice
        /// </summary>
        /// <param name="prod">Product to be removed</param>
        public void RemoveProduct(cls_Product prod)
        {
            try
            {
                //Check to see if that product is actually in the invoice
                foreach (cls_Product item in productList)
                {
                    if (item.Equals(prod))
                    {
                        productList.Remove(item);
                        PropertyChanged(this, new PropertyChangedEventArgs("TotalCost"));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

#endregion

        #region OTHER STUFF


        public override string ToString()
        {
            return Convert.ToString(InvoiceId);
        }

        #endregion
    }
}
