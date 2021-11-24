using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("valeur de a :");
            a = int.Parse(Console.ReadLine());
            while (true)
            {

                Console.Write("valeur de b :");
                b = int.Parse(Console.ReadLine());
                if (b > a) break;
                Console.WriteLine("\tb doit etre supérieur à a !");
            }
            while (true)
            {
                Console.Write("valeur de c :");
                c = int.Parse(Console.ReadLine());
                if (c > b) break;
                Console.WriteLine("\tc doit etre supérieur à b !");

            }
            Console.WriteLine("Saisie terminée");
            Console.ReadKey();
        }
    }
}
