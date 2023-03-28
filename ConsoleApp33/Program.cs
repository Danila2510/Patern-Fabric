using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    interface Transport
    {
        void Zena();
        void Distanciya();
        void Benzin();
        void Deliver();
    }
    public class Korabl : Transport
    {
        public Korabl() { }
        public void Zena() => Console.WriteLine("Ship order = $9,000 + (450 = 1km)");
        public void Distanciya() => Console.WriteLine("Maximum distance = 2500km");
        public void Benzin() => Console.WriteLine("5000 liters/hour");
        public void Deliver()
        {
            Console.WriteLine("Enter distance");
            int dis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your ship order is worth ={dis * 450 + 9000}$");
        }
    }
    public class Gruzovik : Transport
    {
        public Gruzovik() { }
        public void Zena() => Console.WriteLine("Truck order = $850 + ($15 = 1km)");
        public void Distanciya() => Console.WriteLine("Maximum distance = 1800km");
        public void Benzin() => Console.WriteLine("20 liters/km");
        public void Deliver()
        {
            Console.WriteLine("Enter distance");
            int dis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your truck order is worth ={dis * 15 + 850}$");
        }
    }
    public class Samolet : Transport
    {
        public Samolet() { }
        public void Zena() => Console.WriteLine("Aircraft order = $125,000 + ($1,500 = 1km)");
        public void Distanciya() => Console.WriteLine("Maximum distance = 4000km");
        public void Benzin() => Console.WriteLine("13000 литров/час");
        public void Deliver()
        {
            Console.WriteLine("Enter distance");
            int dis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your truck order is worth ={dis * 1500 + 125000}$");
        }
    }


    abstract class Logistic
    {
        virtual public Transport Create() { return null; }
    }
    class Samolet_Logistic : Logistic
    {
        public Samolet_Logistic() { }
        public override Transport Create() { return new Samolet(); }
    }
    class Gruzovik_Logistic : Logistic
    {
        public Gruzovik_Logistic() { }
        public override Transport Create() { return new Gruzovik(); }
    }
    class Korabl_Logistic : Logistic
    {
        public Korabl_Logistic() { }
        public override Transport Create() { return new Korabl(); }
    }

    internal class Program
    {
        static Transport App(Logistic temp)
        {
            return temp.Create();
        }

        static void Main(string[] args)
        {
            Logistic temp = new Korabl_Logistic();
            Transport transport = App(temp);
            transport.Distanciya();
        }
    }
}
