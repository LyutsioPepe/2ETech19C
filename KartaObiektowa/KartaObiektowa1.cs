using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Producent 
	{
		public string nazwa;
		public string nip;
		public string getNazwa()
		{
			return nazwa;
		}
		public string getNip()
		{
			return nip;
		}
		public void setNazwa()
		{
			Console.WriteLine("Jan/Jasiu")
		}
	}

	class Material 
	{
		public string typ;
		public int id;
		public double cena;
		public void setTyp()
		{
			Console.WriteLine("Brak")
		}
		public string getTyp()
		{
			return typ;
		}
		public double getCena()
		{
			return cena;
		}
		public void setId()
		{
			Console.WriteLine("454116")
		}
	}

	class Rower 
	{
		public Producent producent;
		public string color;
		public Material material;
		public void jedz()
		{
			Console.WriteLine("Za 200m skręć w prawo")
		}
		public void setColor()
		{
			Console.WriteLine("Niebieski")
		}
		public string getColor()
		{
			return color;
		}
	}
	class Program 
	{
		public static void Main(string[] args) 
		{
			
		}
	}
}
