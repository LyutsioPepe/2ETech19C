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
      Console.WriteLine("Milk")
    }
    public void getcena() 
    {
      Console.WriteLine("4.80")
    }
    public void getOpis() 
    {
      Console.WriteLine("płynne...?")
    }
    public void Produkt(string nazwa, double cena, string opis)
    {
      Console.WriteLine("Mleko")
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
      Console.WriteLine("Gryczman")
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
    public void operation() {
      Console.WriteLine("operacja plastyczna")
    }
  }

  
  class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
