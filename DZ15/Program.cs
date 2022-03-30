using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(10);
            arith.setStep(3);
            Console.WriteLine("Проверка арифмитической прогрессии:");
            Console.WriteLine(arith.getNext()); //Проверка арифмитической прогрессии
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());

            GeomProgression geom = new GeomProgression();
            geom.setStart(8);
            geom.setStep(2);
            Console.WriteLine("Проверка геометрической прогрессии:");
            Console.WriteLine(geom.getNext()); //Проверка геометрической прогрессии
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
