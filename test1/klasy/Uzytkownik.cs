using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.klasy
{
    internal abstract class Uzytkownik
    {
        public string imie { get; protected set; }
        public string nazwisko { get; protected set; }
        public string login { get; protected set; }
        public string haslo { get; protected set; }

        public Uzytkownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = imie + "_" + nazwisko;
            this.haslo = nazwisko.Substring(0, 3) + losujKod();
            ukryjHaslo();
            ukryjLogin();
        }

        public int losujKod()
        {
            int x = 0;
            Random rand = new Random();
            for(int i = 0; i < 6;i ++)
            {
                x *= 10;
                x += rand.Next(0, 10);
            }
            return x;
        }

        protected void ukryjLogin()
        {
            login = Szyfrowanie.zaszyfrujGADERYPOLUKI(login);
        }

        protected void ukryjHaslo()
        {
            haslo = Szyfrowanie.zaszyfrujGADERYPOLUKI(haslo);
        }

        public string pokazLogin()
        {
            return Szyfrowanie.odszyfrujGADERYPOLUKI(login);
        }

        public string pokazHaslo()
        {
            return Szyfrowanie.odszyfrujGADERYPOLUKI(haslo);
        }

        public abstract void zmienLogin(string nowyLogin, string staryLogin);
        public abstract void zmienHaslo(string noweHaslo, string stareHaslo);
    }
}
