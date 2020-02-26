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
    [Activity(Label = "KlienciActivity")]
    public class KlienciActivity : Activity
    {
        ListView lv;
        CustomerAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Klienci);
            lv = FindViewById<ListView>(Resource.Id.KlienciLista);
            adapter = new CustomerAdapter(this, ZwrocKlientow());
            lv.Adapter = adapter;
        }

        private List<Customer> ZwrocKlientow()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(Ip.ip + "/customers"));
            request.ContentType = "application/json";
            request.Method = "GET";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                Stream responseStream = response.GetResponseStream();
                using (var reader = new StreamReader(responseStream))
                {
                    string responseText = reader.ReadToEnd();
                    IEnumerable<Customer> results = JsonConvert.DeserializeObject<IEnumerable<Customer>>(responseText);
                    return results.ToList<Customer>();
                }
            }
        }
    }
}