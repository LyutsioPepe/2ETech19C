using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Produkt {
    public string nazwa;
    public double cena;
    public string opis;
    public void getNazwa() 
    {
      return nazwa;
    }
    public void getcena() 
    {
      return cena;
    }
    public void getOpis() 
    {
      return opis;
    }
    public void Produkt(string nazwa, double cena, string opis)
    {
      this.nazwa = nazwa;
      this.cena = cena;
      this.opis = opis;
    }
  }

  class Profil {
    public string imie;
    public string drugieImie;
    public string nazwisko;
    public void getImie()
    {
      Console.WriteLine("Jakub")
    }
    public void getNazwisko()
    {
      Console.WriteLine("Grycman")
    }
    public void setNazwisko(string anazwisko)
    {
      this.nazwisko = anazwisko;
    }
  }

  class Uzytkownik {
    public string login;
    public string haslo;
    public Profil profil;
    public void loguj()
    {
      Console.WriteLine("logujemy")
    }
  }

  class Koszyk 
  {
    public int id;
    public Produkt produkt;
    public Uzytkownik uzytkownik;
    public int getId()
        {
            return id;
        }
        public void operation()
        {
            Console.WriteLine("operacja demokracja");
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
  }

  
  class Program
    {
        static void Main(string[] args)
        {
            Profil prof1 = new Profil();
            Uzytkownik u1 = new Uzytkownik(prof1);
            u1.loguj();
            prof1.setNazwisko(" ");
            Produkt prod1 = new Produkt("mleko", 4.80, "płynne...?");
            Koszyk k1 = new Koszyk(prod1);
        }
    }
}
