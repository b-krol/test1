using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.klasy
{
    internal class Student : Uzytkownik, IComparable<Student>
    {

        public int rocznikStudiow { get; protected set; }

        public Student(string imie, string nazwisko, int rocznikStudiow) : base(imie, nazwisko)
        {
            this.rocznikStudiow = rocznikStudiow;
        }
        //
        public override void zmienHaslo(string noweHaslo, string stareHaslo)
        {
            if(this.pokazHaslo() == stareHaslo)
            {
                this.haslo = noweHaslo;
                this.ukryjHaslo();
            }
        }
        //
        public override void zmienLogin(string nowyLogin, string staryLogin)
        {
            if (this.pokazLogin() == staryLogin)
            {
                this.login = nowyLogin;
                this.ukryjLogin();
            }
        }

        public override string ToString()
        {
            return $"{imie} {nazwisko} {rocznikStudiow}\n" +
                $"{login} {haslo}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(((Student)obj).login == this.login)
            {
                if (((Student)obj).haslo == this.haslo)
                {
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return -1;
            if (other.rocznikStudiow > this.rocznikStudiow)
            {
                return -1;
            }
            else if (other.rocznikStudiow < this.rocznikStudiow)
            {
                return 1;
            }
            else if (other.imie.First() > this.imie.First())
            {
                return -1;
            }
            else if (other.imie.First() < this.imie.First())
            {
                return 1;
            }
            else if (other.nazwisko.First() > this.nazwisko.First())
            {
                return -1;
            }
            else if (other.nazwisko.First() < this.nazwisko.First())
            {
                return 1;
            }
            else return 0;
        }
    }
}
