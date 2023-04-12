using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocompletTextBox_Smart.Core
{
    public class ListItem
    {
        public int Clave { get; set; }
        public string DisplayValue { get; set; }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
