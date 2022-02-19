using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Oil
{
    public class Cafe
    {
        public string Food { get; set; }
        public double Food_price { get; set; }
        public override string ToString()
        {
            return $"{Food}";
        }
    }
}
