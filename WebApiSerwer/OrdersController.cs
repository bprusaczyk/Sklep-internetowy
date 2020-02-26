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
    public class OrdersController : ApiController
    {
        static List<Order> zamowienia = new List<Order>
        {
            new Order { Id=1, KlientZ=CustomersController.klienci[0], ProduktZ=ProductsController.products[0], LiczbaSztuk=1 },
            new Order { Id=2, KlientZ=CustomersController.klienci[1], ProduktZ=ProductsController.products[1], LiczbaSztuk=1 },
            new Order { Id=3, KlientZ=CustomersController.klienci[2], ProduktZ=ProductsController.products[2], LiczbaSztuk=3 }
        };

        public IEnumerable<Order> Get()
        {
            Console.WriteLine(DateTime.Now.ToString() + ": zwracam listę zamówień.");
            List<Order> zamowienia = new List<Order>();
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand("SELECT z.id AS idZamowienia, liczbaSztuk, k.id AS idKlienta, imie, nazwisko, p.id AS idProduktu, nazwa, cena FROM zamowienia z, produkty p, klienci k WHERE z.idProduktu=p.id AND z.idKlienta=k.id", polaczenie);
            MySqlDataReader msdr = msc.ExecuteReader();
            while (msdr.Read())
            {
                zamowienia.Add(new Order { Id = Int32.Parse(msdr["idZamowienia"].ToString()), LiczbaSztuk = Int32.Parse(msdr["liczbaSztuk"].ToString()), KlientZ = new Customer { Id = Int32.Parse(msdr["idKlienta"].ToString()), Imie = msdr["imie"].ToString(), Nazwisko = msdr["nazwisko"].ToString() }, ProduktZ = new Product { Id = Int32.Parse(msdr["idProduktu"].ToString()), Nazwa = msdr["nazwa"].ToString(), Cena = Decimal.Parse(msdr["cena"].ToString()) } });
            }
            polaczenie.Close();
            return zamowienia;
        }

        public Order Get(int id)
        {
            var zamowienie = zamowienia.FirstOrDefault(z => z.Id == id);
            if (zamowienia == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return zamowienie;
        }

        [HttpPost]
        public void Post([FromBody] Order value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": modyfikuję listę zamówień.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand("UPDATE zamowienia SET idKlienta=?idKlienta, idProduktu=?idProduktu, liczbaSztuk=?liczbaSztuk WHERE id=?id", polaczenie);
            msc.Parameters.Add("?idKlienta", MySqlDbType.Int32).Value = value.KlientZ.Id;
            msc.Parameters.Add("?idProduktu", MySqlDbType.Int32).Value = value.ProduktZ.Id;
            msc.Parameters.Add("?liczbaSztuk", MySqlDbType.Int32).Value = value.LiczbaSztuk;
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = value.Id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpPut]
        public void Put(int id, [FromBody] Order value)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": dodaję nowe zamówienie.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand("INSERT INTO zamowienia VALUES (null, ?idKlienta, ?idProduktu, ?liczbaSztuk)", polaczenie);
            msc.Parameters.Add("?idKlienta", MySqlDbType.Int32).Value = value.KlientZ.Id;
            msc.Parameters.Add("?idProduktu", MySqlDbType.Int32).Value = value.ProduktZ.Id;
            msc.Parameters.Add("?liczbaSztuk", MySqlDbType.Int32).Value = value.LiczbaSztuk;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Console.WriteLine(DateTime.Now.ToString() + ": kasuję zamówienie.");
            MySqlConnection polaczenie = new MySqlConnection(BazaDanych.connectionString);
            polaczenie.Open();
            MySqlCommand msc = new MySqlCommand("DELETE FROM zamowienia WHERE id=?id", polaczenie);
            msc.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            msc.ExecuteNonQuery();
            polaczenie.Close();
        }

        private static Model zwrocModel(IEnumerable<Model> listaSkad, Model selected)
        {
            foreach (var item in listaSkad)
            {
                if (item.Id == selected.Id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
