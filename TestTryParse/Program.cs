using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int outputInt;

            bool resultOfTryParse;

            do
            {
                Console.WriteLine("Digite um valor inteiro:");
                string typedNumber = Console.ReadLine();
                resultOfTryParse = int.TryParse(typedNumber, out outputInt);
            } while (!resultOfTryParse);

        }
    }
}
