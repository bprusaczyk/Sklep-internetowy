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
    public class CustomersController : ApiController
    {
        public static List<Customer> klienci = new List<Customer>
        {
            new Customer { Id=1, Imie="Jan", Nazwisko="Kowalski" },
            new Customer { Id=2, Imie="Jan", Nazwisko="Nowak" },
            new Customer { Id=3, Imie="Anna", Nazwisko="Nowak" }
        };

        public IEnumerable<Customer> Get()
        {
            Console.WriteLine(DateTime.Now.ToString() + ": zwracam listę klientów.");
            List<Customer> klienci = new List<Customer>();
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM klienci", polaczenie);
            DataSet ds = new DataSet();
            msda.Fill(ds, "klienci");
            DataTable dt = ds.Tables["klienci"];
            foreach (DataRow item in dt.Rows)
            {
                klienci.Add(new Customer { Id = Int32.Parse(item["id"].ToString()), Imie = item["imie"].ToString(), Nazwisko = item["nazwisko"].ToString() });
            }
            polaczenie.Close();
            return klienci;
        }

        public Customer Get(int id)
        {
            var klient = klienci.FirstOrDefault(k => k.Id == id);
            if (klient == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return klient;
        }

        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": modyfikuję listę klientów.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "UPDATE klienci SET imie=?imie, nazwisko=?nazwisko WHERE id=?id";
            msc.Parameters.Add("?imie", MySqlDbType.Text).Value = value.Imie;
            msc.Parameters.Add("?nazwisko", MySqlDbType.Text).Value = value.Nazwisko;
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = value.Id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpPut]
        public void Put(int id, [FromBody] Customer value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": dodaję nowego klienta.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "INSERT INTO klienci VALUES (null, ?imie, ?nazwisko)";
            msc.Parameters.Add("?imie", MySqlDbType.Text).Value = value.Imie;
            msc.Parameters.Add("?nazwisko", MySqlDbType.Text).Value = value.Nazwisko;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": kasuję klienta.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand(null, polaczenie);
            msc.CommandText = "DELETE FROM klienci WHERE id=?id";
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }
    }
}