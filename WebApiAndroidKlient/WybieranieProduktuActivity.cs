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
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WebApiAndroidKlient
{
    [Activity(Label = "WybieranieProduktuActivity")]
    public class WybieranieProduktuActivity : Activity
    {
        ListView lv;
        ProduktAdapter adapter;
        static HttpClient client = new HttpClient();
        List<Product> lista;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WybieranieProduktu);
            lv = FindViewById<ListView>(Resource.Id.ProduktyLista);
            lista = ZwrocProdukty().ToList<Product>();
            adapter = new ProduktAdapter(this, lista);
            lv.Adapter = adapter;
            lv.ItemClick += Lv_ItemClick;
        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(WybieranieProduktuActivity));
            i.PutExtra("id", lista[e.Position].Id);
            i.PutExtra("nazwa", lista[e.Position].Nazwa);
            i.PutExtra("cena", lista[e.Position].Cena.ToString());
            SetResult(Result.Ok, i);
            Finish();
        }

        private IEnumerable<Product> ZwrocProdukty()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(Ip.ip + "/products"));
            request.ContentType = "application/json";
            request.Method = "GET";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                Stream responseStream = response.GetResponseStream();
                using (var reader = new StreamReader(responseStream))
                {
                    string responseText = reader.ReadToEnd();
                    IEnumerable<Product> results = JsonConvert.DeserializeObject<IEnumerable<Product>>(responseText);
                    return results;
                }
            }
        }
    }
}