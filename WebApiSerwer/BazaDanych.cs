using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSerwer
{
    class BazaDanych
    {
        private static readonly string SERWER = "localhost";
        private static readonly string BAZA_DANYCH = "sklep_internetowy";
        private static readonly string UZYTKOWNIK = "root";
        private static readonly string HASLO = string.Empty;
        public static string connectionString = "SERVER=" + SERWER + ";DATABASE=" + BAZA_DANYCH + ";UID=" + UZYTKOWNIK + ";PASSWORD=" + HASLO + ";";
    }
}
