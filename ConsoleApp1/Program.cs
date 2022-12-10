using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    abstract class Figure
    {
        public abstract void Circle();
      
        public abstract void Rectangle();
    }
    class Area : Figure
    {
        public override void Rectangle()
        {
            Console.WriteLine("사각형 그리기");
        }
        public override void Circle()
        {
            Console.WriteLine("원그리기");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.Circle();
            area.Rectangle();
        }
    }
}
