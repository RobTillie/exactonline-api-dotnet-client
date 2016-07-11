using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Models
{
    public class SDKFieldType : Attribute
    {
        public FieldType TypeOfField { get; set; }

        public SDKFieldType(FieldType fieldType)
        {
            TypeOfField = fieldType;
        }
    }
}
