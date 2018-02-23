using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChangeDecomposer
{
    class Program
    {
        static void Main(string[] args)
        {

            double amount;

            uint[] valorNota = { 20, 10, 5, 2, 1 };
            List<uint> quanttyNota = new List<uint>();

            bool resultOfTryParse;
            /*
            do
            {
                Console.WriteLine("Digite uma quantia:");
                string typedNumber = Console.ReadLine();
                resultOfTryParse = double.TryParse(typedNumber, out amount);
            } while (!resultOfTryParse);
            */
            amount = 56;
            double newAmount = amount;
            for(uint i = 0; i < 5; i++)
            {
                uint quotient = (uint) newAmount / valorNota[i];
                uint remaining = (uint)newAmount % valorNota[i];
                //Console.WriteLine("i = " + i);
                quanttyNota.Add(quotient);

                //Console.WriteLine(quanttyNota.ElementAt((int)i) + " nota de R$" + valorNota[i] + ",00");
                Console.WriteLine($"{quanttyNota.ElementAt((int)i)} nota de R$ {valorNota[i]},00");

                newAmount = remaining;
            }

            Console.ReadKey();

        }
    }
}
