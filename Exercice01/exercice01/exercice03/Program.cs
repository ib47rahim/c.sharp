using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization

namespace exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            // récupération du séparateur défini sur le système
            string separateur = CultureInfo.CurrentCulture.NumberFormat.

            Console.WriteLine("note :");
            string valeur saisie = Console.ReadLine();
            if (valeurSaisie) = Console.ReadLine();
            if (valeurSaisie == "AB" || valeurSaisie == "ab") break;
            //on change eventuellement le séparateur
            if (separateur == ".")
            {
                valeurSaisie = valeurSaisie.Replace(',', ",");
            }
            if (decimal.TryParse(valeurSaisie,out decimal note))
        {
                if (note >= 0 && note <= 20 && Math.Floor(note * 2) == note * 2) beak;
        }
        Console.WriteLine("Note acceptée");
        Console.Readkey();
    }
}
