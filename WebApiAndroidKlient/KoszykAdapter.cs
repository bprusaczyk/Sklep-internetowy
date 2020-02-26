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
    class KoszykAdapter : BaseAdapter<Order>
    {
        Activity context;
        List<Order> lista = new List<Order>();

        public KoszykAdapter(Activity context) : base()
        {
            this.context = context;
            lista = Koszyk.koszyk;
        }

        public KoszykAdapter(Activity context, List<Order> lista) : base()
        {
            this.context = context;
            this.lista = lista;
        }

        public override Order this[int position]
        {
            get
            {
                return lista.ElementAt(position);
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
                view = context.LayoutInflater.Inflate(Resource.Layout.layout1, null);
            }
            view.FindViewById<TextView>(Resource.Id.listaKoszykNazwa).Text = item.ProduktZ.Nazwa;
            view.FindViewById<TextView>(Resource.Id.listaKoszykLiczbaSztuk).Text = "Liczba sztuk: " + item.LiczbaSztuk.ToString();
            view.FindViewById<TextView>(Resource.Id.listaKoszykCena).Text = "Razem: " + (item.LiczbaSztuk * item.ProduktZ.Cena).ToString();
            return view;
        }
    }
}