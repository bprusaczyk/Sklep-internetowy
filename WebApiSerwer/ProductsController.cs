using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiSerwer
{
    public class ProductsController : ApiController
    {
        public static List<Product>products = new List<Product>
        {
            new Product { Id=1, Nazwa="Zotac GeForce RTX 2080 Super Amp Extreme 8 GB", Cena=3900 },
            new Product { Id=2, Nazwa="Abilix Krypton 0", Cena=500 },
            new Product { Id=3, Nazwa="Dell G7 17", Cena=7250 }
        };

        public IEnumerable<Product> Get()
        {
            Console.WriteLine(DateTime.Now.ToString() + ": zwracam listę produktów.");
            List<Product> produkty = new List<Product>();
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM PRODUKTY", polaczenie);
            DataSet ds = new DataSet();
            msda.Fill(ds, "produkty");
            DataTable dt = ds.Tables["produkty"];
            foreach (DataRow item in dt.Rows)
            {
                produkty.Add(new Product { Id = Int32.Parse(item["id"].ToString()), Cena = Decimal.Parse(item["cena"].ToString()), Nazwa = item["nazwa"].ToString() });
            }
            polaczenie.Close();
            return produkty;
        }

        public Product Get(int id)
        {
            var produkt = products.FirstOrDefault(p => p.Id == id);
            if (produkt == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return produkt;
        }

        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": modyfikuję listę produktów.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "UPDATE produkty SET nazwa=?nazwa, cena=?cena WHERE id=?id";
            msc.Parameters.Add("?nazwa", MySqlDbType.Text).Value = value.Nazwa;
            msc.Parameters.Add("?cena", MySqlDbType.Decimal).Value = value.Cena;
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = value.Id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpPut]
        public void Put(int id, [FromBody] Product value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": dodaję nowy produkt.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "INSERT INTO produkty VALUES (null, ?nazwa, ?cena)";
            msc.Parameters.Add("?nazwa", MySqlDbType.Text).Value = value.Nazwa;
            msc.Parameters.Add("?cena", MySqlDbType.Decimal).Value = value.Cena;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": kasuję produkt.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "DELETE FROM produkty WHERE id=?id";
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }
    }
}
