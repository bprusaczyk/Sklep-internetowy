using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSerwer
{
    public class Product : Model
    {
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
