using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Oil
{
    public class Gasoline
    {
        public string Gas_name { get; set; }
        public double Gas_price { get; set; }
        public override string ToString()
        {
            return $"{Gas_name}";
        }
    }
}
