using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double h;
            double area;

            Console.WriteLine("Calculo da area do triangulo");
            Console.WriteLine();

            Console.WriteLine("digite Valor da Base");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("digite Valor da Altura");
            h = double.Parse(Console.ReadLine());
            
            area = b * h / 2;
            Console.WriteLine("area:"+area);
        
       
        }
    }
}
