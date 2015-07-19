using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первый параметр: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй параметр: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий параметр: ");
            double c = double.Parse(Console.ReadLine());
            Box m = new Box(a, b, c);
            m.DisplayShow();
            Console.WriteLine("Диагональ =" + m.Diagonal());
            Console.WriteLine("Введите первый параметр грани: ");
            float A = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй параметр грани: ");
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            m.Sround(A, B);
            Console.ReadKey();
        }
    }
}
