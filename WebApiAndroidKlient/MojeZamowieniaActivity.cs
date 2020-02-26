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
    [Activity(Label = "MojeZamowieniaActivity")]
    public class MojeZamowieniaActivity : Activity
    {
        ListView lv;
        KoszykAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MojeZamowienia);
            lv = FindViewById<ListView>(Resource.Id.MojeZamowieniaLista);
            adapter = new KoszykAdapter(this, ZwrocZamowienia());
            lv.Adapter = adapter;
        }

        private List<Order> ZwrocZamowienia()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(Ip.ip + "/orders"));
            request.ContentType = "application/json";
            request.Method = "GET";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                Stream responseStream = response.GetResponseStream();
                using (var reader = new StreamReader(responseStream))
                {
                    string responseText = reader.ReadToEnd();
                    IEnumerable<Order> results = JsonConvert.DeserializeObject<IEnumerable<Order>>(responseText);
                    IEnumerable<Order> pom = results.Where(x => x.KlientZ.Id == 1);
                    return pom.ToList<Order>();
                }
            }
        }
    }
}