using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSerwer
{
    public class Order
    {
        public int Id { get; set; }
        public Product ProduktZ { get; set; }
        public int LiczbaSztuk { get; set; }
        public Customer KlientZ { get; set; }

        public override string ToString()
        {
            return Id.ToString() + ". " + LiczbaSztuk.ToString() + " x " + (ProduktZ.ToString() ?? "<nieznany produkt>") + " dla " + (KlientZ.ToString() ?? "<nieznany klient>");
        }
    }
}
