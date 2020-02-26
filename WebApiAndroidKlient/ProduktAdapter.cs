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
    class ProduktAdapter : BaseAdapter<Product>
    {
        private List<Product> lista = new List<Product>();
        private Activity context;

        public ProduktAdapter(Activity context, List<Product> lista) : base()
        {
            this.context = context;
            this.lista = lista;
        }

        public override Product this[int position]
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
                view = context.LayoutInflater.Inflate(Resource.Layout.PoleListyProdukty, null);
            }
            switch (item.Nazwa)
            {
                case "Palit GeForce GTX 1660 SUPER GamingPRO OC":
                    view.FindViewById<ImageView>(Resource.Id.ProduktyObrazek).SetImageResource(Resource.Drawable.palit);
                    break;
                case "Sega Mega Drive Mini":
                    view.FindViewById<ImageView>(Resource.Id.ProduktyObrazek).SetImageResource(Resource.Drawable.sega);
                    break;
                case "Cooler Master Cosmos C700M":
                default:
                    view.FindViewById<ImageView>(Resource.Id.ProduktyObrazek).SetImageResource(Resource.Drawable.cooler);
                    break;
            }
            view.FindViewById<TextView>(Resource.Id.ProduktyNazwa).Text = item.Nazwa;
            view.FindViewById<TextView>(Resource.Id.ProduktyCena).Text = item.Cena.ToString();
            return view;
        }
    }
}