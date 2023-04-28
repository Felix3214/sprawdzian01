using sprawdzian01.zadanka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian01.zad2
{
    public abstract class Uzytkownik
    {
        protected string imie;
        protected string nazwisko;
        protected string login;
        protected string haslo;

        public Uzytkownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = GenerujLogin();
            this.haslo = GenerujHaslo();
        }

        public string UkryjLogin()
        {
            return Szyfrowanie.Szyfruj(this.login);
        }

        public string UkryjHaslo()
        {
            return Szyfrowanie.Szyfruj(this.haslo);
        }

        public string PokazLogin()
        {
            return this.login;
        }

        public string PokazHaslo()
        {
            return this.haslo;
        }

        public abstract void ZmienLogin(string nowyLogin, string StaryLoginOdUzytkownika);

        public abstract void ZmienHaslo(string noweHaslo, string StareHasloOdUzytkownika);

        private string GenerujLogin()
        {
            return $"{this.imie.ToLower()}_{this.nazwisko.ToLower()}";
        }

        private string GenerujHaslo()
        {
            return $"{this.nazwisko.Substring(0, 3).ToLower()}{LosowaLiczba():D6}";
        }

        private int LosowaLiczba()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }

        internal int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }
    }

    public static class Szyfrowanie
    {
        public static string Szyfruj(string tekst)
        {
          
            return "szyfrowany_tekst";
        }
    }

}
