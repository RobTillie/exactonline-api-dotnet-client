using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    // Simulates the actual class used in the API
    public class DataServiceKeyAttribute : Attribute
    {
        private string _dataServiceKey;

        public DataServiceKeyAttribute(string dataServiceKey)
        {
            _dataServiceKey = dataServiceKey;
        }

        public DataServiceKeyAttribute(string dataServiceKey, string dataServiceKey2)
        {
            _dataServiceKey = dataServiceKey;
        }

        public DataServiceKeyAttribute(string dataServiceKey, string dataServiceKey2, string dataServiceKey3)
        {
            _dataServiceKey = dataServiceKey;
        }

        public string DataServiceKey
        {
            get { return _dataServiceKey; }
            set { _dataServiceKey = value; }
        }
    }

    //=======================================================
    //Service provided by Telerik (www.telerik.com)
    //Conversion powered by NRefactory.
    //Twitter: @telerik
    //Facebook: facebook.com/telerik
    //=======================================================
}
