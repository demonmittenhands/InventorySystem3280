using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace RecreationOutlet
{

    public class cls_Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// Used for notifying databindings of changes in the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Customer's Name
        /// </summary>
        private string s_name;

        /// <summary>
        /// Customer ID from Database
        /// </summary>
        private int i_customerID;

        /// <summary>
        /// Customer's Email Address
        /// </summary>
        private string s_email;

        /// <summary>
        /// Customer's Name
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
        /// Customer's Email Address
        /// </summary>
        public string Email
        {
            get
            {
                try
                {
                    return s_email;
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
                    s_email = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Customer ID from Database
        /// </summary>
        public int CustomerID
        {
            get
            {
                try
                {
                    return i_customerID;
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
                    i_customerID = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        public cls_Customer(string name, int id, string email)
        {
            s_name = name;
            i_customerID = id;
            s_email = email;
        }

        public cls_Customer(string name, int id)
        {
            s_name = name;
            i_customerID = id;
        }

        public cls_Customer(int id)
        {
            i_customerID = id;
        }
    }
}
