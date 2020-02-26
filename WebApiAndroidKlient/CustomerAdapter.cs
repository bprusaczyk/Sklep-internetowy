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

namespace WebApiAndroidKlient
{
    class CustomerAdapter : BaseAdapter<Customer>
    {
        private List<Customer> lista = new List<Customer>();
        private Activity context;

        public CustomerAdapter(Activity context, List<Customer> lista) : base()
        {
            this.context = context;
            this.lista = lista;
        }

        public override Customer this[int position]
        {
            get
            {
                return lista.ElementAt<Customer>(position);
            }
        }

        public override int Count
        {
            get
            {
                return lista.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista.ElementAt(position);
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.PoleListyKlient, null);
            }
            view.FindViewById<TextView>(Resource.Id.KlientNazwisko).Text = item.Nazwisko;
            view.FindViewById<TextView>(Resource.Id.KlientImie).Text = item.Imie;
            return view;
        }
    }
}