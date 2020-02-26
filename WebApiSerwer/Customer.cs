using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSerwer
{
    public class Customer : Model
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }
    }
}
