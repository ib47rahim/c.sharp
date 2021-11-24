using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int nb = 0;
            double s = 0;


            while (true)
            {
                Console.write("note :");
                double note = double.Parse(Console.ReadLine());
                if (Note == 99) break;
                if (Note < 0 || note > 20)
                {
                    Console.WriteLine("cette note n'est pas valide");
                }
                else
                {
                    s = s + note;
                    nb = nb + 1;
                }

            }
            if (nb == 0)    
            { 
               console.writeline("aucune note saisie");
            }else
            { 

}
