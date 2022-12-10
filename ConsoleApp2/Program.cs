using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IFigure
{
   void Rectangle();
    void Circle();

}
class figure : IFigure
{
    public void Rectangle()
    {
        Console.WriteLine("사각형 그리기");
    }
    public void Circle()
    {
        Console.WriteLine("원그리기");
    }
}
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            figure a=new figure();
            a.Rectangle();
            a.Circle();
        }
    }
}
