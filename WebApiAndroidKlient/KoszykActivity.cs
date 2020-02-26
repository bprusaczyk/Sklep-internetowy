using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WebApiAndroidKlient
{
    [Activity(Label = "KoszykActivity")]
    public class KoszykActivity : Activity
    {
        ListView lv;
        KoszykAdapter adapter;
        Button dodajNowyProdukt;
        Button zrealizujZamowienie;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.koszyk);
            lv = FindViewById<ListView>(Resource.Id.koszykLZ);
            adapter = new KoszykAdapter(this);
            lv.Adapter = adapter;
            dodajNowyProdukt = FindViewById<Button>(Resource.Id.KoszykDodajNowyProdukt);
            dodajNowyProdukt.Click += DodajNowyProdukt_Click;
            zrealizujZamowienie = FindViewById<Button>(Resource.Id.KoszykZrealizujZamowienie);
            zrealizujZamowienie.Click += ZrealizujZamowienie_Click;
        }

        private void ZrealizujZamowienie_Click(object sender, EventArgs e)
        {
            ZrealizujZamowienie();
            Koszyk.koszyk.Clear();
            adapter.NotifyDataSetChanged();
        }

        private void ZrealizujZamowienie()
        {
            foreach (var item in Koszyk.koszyk)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(Ip.ip + "/orders/0"));
                request.ContentType = "application/json";
                request.Method = "PUT";
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(item);
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }



                //using (var response = request.GetResponse() as HttpWebResponse)
                //{
                //    Stream responseStream = response.GetResponseStream();
                //    using (var reader = new StreamReader(responseStream))
                //    {
                //        string responseText = reader.ReadToEnd();
                //        IEnumerable<Product> results = JsonConvert.DeserializeObject<IEnumerable<Product>>(responseText);
                //        //return results;
                //    }
                //}
            }
        }

        private void DodajNowyProdukt_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(DodawanieDoKoszykaActivity));
            StartActivityForResult(i, 0);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                int id = data.GetIntExtra("id", 0);
                string nazwa = data.GetStringExtra("nazwa");
                decimal cena = Decimal.Parse(data.GetStringExtra("cena"));
                int liczbaSztuk = data.GetIntExtra("liczba sztuk", 1);
                if (Koszyk.koszyk == null) Koszyk.koszyk = new List<Order>();
                Koszyk.koszyk.Add(new Order { Id = id, KlientZ = new Customer{ Id = 1, Imie = "Jan", Nazwisko = "Kowalski" }, LiczbaSztuk = liczbaSztuk, ProduktZ = new Product { Cena = cena, Id = id, Nazwa = nazwa } });
                adapter.NotifyDataSetChanged();
            }
        }
    }
}