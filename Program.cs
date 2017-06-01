using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IA
    {
        string GetName();
    }

    interface IB
    {
        string GetName();
    }

    //struct A
    //{
    //    //public A(int _T, int _p)
    //    //{
    //    //    this.T = _T;
    //    //    this.p = _p;
    //    //}
    //    public int T { get; set; }
    //    public int p { get; set; }
    //}

    abstract class Vehicle
    {
        public virtual string Driver(ref int count)
        {
            // var list = Enumerable.Range(1, 100).ToList();
            // list.w.ForEach(Car.DoSomething);
            return "Vehicle";
        }
    }

    class Car : Vehicle
    {
        public override string Driver(ref int count)
        {
            count = 6;
            return "Car";
        }
        public static Action<int> DoSomething()
        {
            return null;
        }
    }

    class Shape : IA, IB
    {
        public string GetName()
        {
            return "shapeA";
        }

        string IB.GetName()
        {
            return "shapeB";
        }
    }

    class Ball : Shape
    {
        public new string GetName() { return "ball"; }
    }

    class Pet: IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual string GetName() { return "pet"; }
    }

    class Cat : Pet, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            return "cat";
        }

        public string GetSername()
        {
            return "SPet";
        }

        
    }

    public class Program
    {
        //static void Cts(ref string w ) { w = "sunny"; }
        //static void Cta(string[] ws) { ws[1] = "Sunday"; }
        //static void ctst(A a) { a.T = 35; }

        public static void Main(string[] args)
        {
            //    string r = "Monday";
            //    Cts(ref r);
            //    Console.Write(r + "\n");

            //    A a = new A { T = 700, p = 20 };
            //    ctst(a);
            //    Console.Write(a.T);
            //    Console.ReadKey();
            int countv = 4;
            int conntc = 3;
            Vehicle v = new Car();
            Car car = new Car();

            Pet p = new Cat();
            Cat c = new Cat();

            // p = c;

            // Cat cp = new Pet(); error
            Shape shape = new Shape();
            Shape s = new Ball();
            Ball b = new Ball();

            s = b;

            Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}"
                , p.GetName(), c.GetName(), s.GetName(), b.GetName(), object.Equals(s, b)
                , v.Driver(ref countv), car.Driver(ref conntc), conntc, shape.GetName());
            Console.ReadKey();
        }

    }
}
