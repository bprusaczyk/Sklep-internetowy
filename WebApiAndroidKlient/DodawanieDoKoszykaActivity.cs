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
    [Activity(Label = "DodawanieDoKoszykaActivity")]
    public class DodawanieDoKoszykaActivity : Activity
    {
        Button dodajProdukt;
        Button dodajZamowienie;
        EditText liczbaSztuk;
        Product tempProduct;
        TextView nazwaProduktu;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DodawanieDoKoszyka);
            dodajProdukt = FindViewById<Button>(Resource.Id.DodawanieDoKoszykaWybierzProdukt);
            dodajProdukt.Click += DodajProdukt_Click;
            dodajZamowienie = FindViewById<Button>(Resource.Id.DodawanieDoKoszykaDodaj);
            dodajZamowienie.Click += DodajZamowienie_Click;
            liczbaSztuk = FindViewById<EditText>(Resource.Id.DodawanieDoKoszykaLiczbaSztuk);
            nazwaProduktu = FindViewById<TextView>(Resource.Id.DodawanieDoKoszykaNazwaProduktu);
        }

        private void DodajZamowienie_Click(object sender, EventArgs e)
        {
            if (liczbaSztuk.Text == String.Empty)
            {
                Toast.MakeText(Application.Context, "Podaj liczbę sztuk", ToastLength.Long).Show();
                return;
            }
            Intent i = new Intent(this, typeof(KoszykActivity));
            i.PutExtra("id", tempProduct.Id);
            i.PutExtra("nazwa", tempProduct.Nazwa);
            i.PutExtra("cena", tempProduct.Cena.ToString());
            i.PutExtra("liczba sztuk", Int32.Parse(liczbaSztuk.Text));
            SetResult(Result.Ok, i);
            Finish();
        }

        private void DodajProdukt_Click(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(WybieranieProduktuActivity));
            StartActivityForResult(i, 1000);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                int id = data.GetIntExtra("id", 0);
                string nazwa = data.GetStringExtra("nazwa");
                decimal cena = Decimal.Parse(data.GetStringExtra("cena"));
                tempProduct = new Product { Id = id, Cena = cena, Nazwa = nazwa };
                nazwaProduktu.Text = tempProduct.Nazwa;
            }
        }
    }
}