using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.WWI.Customers.Model
{
    public partial class Customers
    {
        public int AccountAntiquity
        {
            get
            {
                int myYears = 0;
                myYears = (int)((DateTime.Now - AccountOpenedDate).TotalDays / 365.2425);
                return myYears;
            }
            set
            {
                ;
            }
        }

        public string BillToCustomerName{ get {
                string result = string.Empty;
                if (Customers2 != null)
                    result = Customers2.CustomerName;
                return result;
            } set { } }

    }
}
