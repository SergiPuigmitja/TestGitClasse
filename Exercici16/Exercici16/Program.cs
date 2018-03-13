using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici16
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcio;
            MostrarOpcions();
            opcio = Console.ReadLine();

            if(opcio == "1")
            {
                Buscamines();
            }

        }

        private static void Buscamines()
        {
            Console.WriteLine("ESTAS JUGANT AL BUSCAMINES...");
        }

        private static void MostrarOpcions()
        {
            Console.WriteLine("Opcio {0}: {1}", 1, "Buscaminas");
            Console.WriteLine("Opcio {0}: {1}", 2, "Solitario");
            Console.WriteLine("Opcio {0}: {1}", 3, "Blackjack");
            Console.WriteLine("Opcio {0}: {1}", 4, "Poker");
        }
    }
}
