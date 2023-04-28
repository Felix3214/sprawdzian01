using sprawdzian01.folderek;
using sprawdzian01.zad2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian01.zadanka
{
    public class Student : Uzytkownik, IComparable<Student>
    {
        private int rocznikStudiow;

        public Student(string imie, string nazwisko, int rocznikStudiow) : base(imie, nazwisko)
        {
            this.rocznikStudiow = rocznikStudiow;
        }

     
        public int CompareTo(Student other)
        {
     
            if (this.rocznikStudiow.CompareTo(other.rocznikStudiow) != 0)
            {
                return this.rocznikStudiow.CompareTo(other.rocznikStudiow);
            }
            else
            {
                return base.CompareTo(other);
            }
        }

        public override void ZmienLogin(string nowyLogin, string StaryLoginOdUzytkownika)
        {
            if (this.login != StaryLoginOdUzytkownika)
            {
                throw new ArgumentException("Nieprawidłowy login użytkownika");
            }

            this.login = nowyLogin;
        }

        public override void ZmienHaslo(string noweHaslo, string StareHasloOdUzytkownika)
        {
            if (this.haslo != StareHasloOdUzytkownika)
            {
                throw new ArgumentException("Nieprawidłowe hasło użytkownika");
            }

            this.haslo = noweHaslo;
        }

        public override string ToString()
        {
            return $"Student: {this.imie} {this.nazwisko}, {UkryjLogin()}, {UkryjHaslo()}, rocznik studiów: {this.rocznikStudiow}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                Student other = (Student)obj;
                return this.login == other.login && this.haslo == other.haslo;
            }
            else
            {
                return false;
            }
        }

    }
}




