using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace WebApiAndroidKlient
{
    [Activity(Label = "WebApiAndroidKlient", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button koszyk;
        Button mojeZamowienia;
        Button klienci;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            koszyk = FindViewById<Button>(Resource.Id.koszykEkranGlowny);
            koszyk.Click += Koszyk_Click;
            mojeZamowienia = FindViewById<Button>(Resource.Id.EkranGlownyMojeZamowienia);
            mojeZamowienia.Click += MojeZamowienia_Click;
            klienci = FindViewById<Button>(Resource.Id.EkranGlownyKlienci);
            klienci.Click += Klienci_Click;
        }

        private void Klienci_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(KlienciActivity));
            StartActivity(i);
        }

        private void MojeZamowienia_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(MojeZamowieniaActivity));
            StartActivity(i);
        }

        private void Koszyk_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(KoszykActivity));
            StartActivity(i);
        }
    }
}

