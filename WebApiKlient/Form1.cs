using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiSerwer;

namespace WebApiKlient
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:1508");
            pobierzProdukty();
            pobierzInformacjeOKlientach();
            pobierzInformacjeOZamowieniach();
        }

        private void pobierzProduktyPrzycisk_Click(object sender, EventArgs e)
        {
            pobierzProdukty();
        }

        private void pobierzProdukty()
        {
            produktyListBox.Items.Clear();
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/products").Result;
                resp.EnsureSuccessStatusCode();
                var produkty = resp.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var p in produkty)
                {
                    produktyListBox.Items.Add(p);
                }
                poleProdukt.DataSource = null;
                poleProdukt.DataSource = produktyListBox.Items;
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void produktyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Product p = (Product)produktyListBox.SelectedItem;
                poleId.Text = p.Id.ToString();
                poleNazwa.Text = p.Nazwa;
                poleCena.Text = p.Cena.ToString();
            }
            catch (NullReferenceException) { }
        }

        private void modyfikujPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                Product pom = new Product { Id = Int32.Parse(poleId.Text), Cena = decimal.Parse(poleCena.Text), Nazwa = poleNazwa.Text };
                var resp = client.PostAsJsonAsync<Product>("api/products", pom).Result;
                if (resp.IsSuccessStatusCode)
                {
                    pobierzProdukty();
                    pobierzInformacjeOZamowieniach();
                }
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void pobierzInformacjeOKlientachPrzycisk_Click(object sender, EventArgs e)
        {
            pobierzInformacjeOKlientach();
        }

        public void pobierzInformacjeOKlientach()
        {
            klienciListBox.Items.Clear();
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/customers").Result;
                resp.EnsureSuccessStatusCode();
                var klienci = resp.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
                foreach (var k in klienci)
                {
                    try
                    {
                        klienciListBox.Items.Add(k);
                    }
                    catch (ArgumentNullException) { }
                }
                poleKlient.DataSource = null;
                poleKlient.DataSource = klienciListBox.Items;
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void klienciListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Customer p = (Customer)klienciListBox.SelectedItem;
                poleIdKlienci.Text = p.Id.ToString();
                poleImie.Text = p.Imie;
                poleNazwisko.Text = p.Nazwisko;
            }
            catch (NullReferenceException) { }
        }

        private void modyfikujKlienciPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                Customer pom = new Customer { Id = Int32.Parse(poleIdKlienci.Text), Imie = poleImie.Text, Nazwisko = poleNazwisko.Text };
                var resp = client.PostAsJsonAsync<Customer>("api/customers", pom).Result;
                if (resp.IsSuccessStatusCode)
                {
                    pobierzInformacjeOKlientach();
                    pobierzInformacjeOZamowieniach();
                }
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void pobierzInformacjeOZamowieniachPrzycisk_Click(object sender, EventArgs e)
        {
            pobierzInformacjeOZamowieniach();
        }

        private void pobierzInformacjeOZamowieniach()
        {
            zamowieniaListBox.Items.Clear();
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/orders").Result;
                resp.EnsureSuccessStatusCode();
                var zamowienia = resp.Content.ReadAsAsync<IEnumerable<Order>>().Result;
                foreach (var z in zamowienia)
                {
                    try
                    {
                        zamowieniaListBox.Items.Add(z);
                    }
                    catch (ArgumentNullException) { }
                }
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void zamowieniaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Order o = (Order)zamowieniaListBox.SelectedItem;
                poleIdZamowienia.Text = o.Id.ToString();
                poleLiczbaSztuk.Text = o.LiczbaSztuk.ToString();
                poleProdukt.SelectedItem = zwrocModel(poleProdukt.Items.Cast<Product>(), ((Order)zamowieniaListBox.SelectedItem).ProduktZ);
                poleKlient.SelectedItem = zwrocModel(poleKlient.Items.Cast<Customer>(), ((Order)zamowieniaListBox.SelectedItem).KlientZ);
            }
            catch (NullReferenceException) { }
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

        private void modyfikujZamowieniaPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                Order pom = new Order { Id = Int32.Parse(poleIdZamowienia.Text), ProduktZ = (Product)poleProdukt.SelectedItem, LiczbaSztuk = Int32.Parse(poleLiczbaSztuk.Text), KlientZ = (Customer)poleKlient.SelectedItem };
                var resp = client.PostAsJsonAsync<Order>("api/orders", pom).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzInformacjeOZamowieniach();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void dodajNowyProduktPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product { Id = 1, Cena = decimal.Parse(poleCena.Text), Nazwa = poleNazwa.Text };
                var resp = client.PutAsJsonAsync<Product>("api/products/0", p).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzProdukty();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void usunProduktPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = client.DeleteAsync("api/products/" + ((Product)produktyListBox.SelectedItem).Id.ToString()).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzProdukty();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }

        private void dodajNowyPrzyciskKlienci_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer { Id = 1, Imie = poleImie.Text, Nazwisko = poleNazwisko.Text };
                var resp = client.PutAsJsonAsync<Customer>("api/customers/0", c).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzInformacjeOKlientach();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void zlozZamowieniePrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                Order o = new Order { Id = 1, ProduktZ = (Product)poleProdukt.SelectedItem, LiczbaSztuk = Int32.Parse(poleLiczbaSztuk.Text), KlientZ = (Customer)poleKlient.SelectedItem };
                var resp = client.PutAsJsonAsync<Order>("api/orders/0", o).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzInformacjeOZamowieniach();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void usunKlienciPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = client.DeleteAsync("api/customers/" + ((Customer)klienciListBox.SelectedItem).Id.ToString()).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzInformacjeOKlientach();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }

        private void usunZamowieniaPrzycisk_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = client.DeleteAsync("api/orders/" + ((Order)zamowieniaListBox.SelectedItem).Id.ToString()).Result;
                if (resp.IsSuccessStatusCode)
                    pobierzInformacjeOZamowieniach();
            }
            catch (HttpRequestException hre)
            {
                MessageBox.Show(hre.Message);
            }
            catch (AggregateException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }
    }
}
