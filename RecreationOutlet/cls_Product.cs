using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace RecreationOutlet
{
    public class cls_Product : INotifyPropertyChanged
    {
        /// <summary>
        /// Used for notifying databindings of changes in the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private int i_prodId;
        private string s_name;
        private string s_description;
        private double d_price;

        public cls_Product(int id, string name, double price)
        {
            i_prodId = id;
            s_name = name;
            d_price = price;
        }

        public cls_Product(int id, string name, double price, string description)
        {
            i_prodId = id;
            s_name = name;
            d_price = price;
            s_description = description;
        }

        /// <summary>
        /// Product ID.  Mainly used for database.
        /// </summary>
        public int ProductID { 
            get 
            {
                try
                {
                    return i_prodId;
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
                    i_prodId = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductID"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return s_name;
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
                    s_name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Short description of the product.
        /// </summary>
        public string Description
        {
            get
            {
                try
                {
                    return s_description;
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
                    s_description = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// The price of the product.
        /// </summary>
        public double Price
        {
            get
            {
                try
                {
                    return d_price;
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
                    d_price = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }
    }
}
