using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixaObj = new Caixa();

            caixaObj.CalculaSaldo();

            Produto prodObj = new Produto();

            /*
             * Showing Product Features
             */
            Console.WriteLine("Product name registered:\n" + prodObj.Name);
            Console.WriteLine("Price\n" + prodObj.Price);
            Console.WriteLine("Code\n" + prodObj.Code);

            
            uint productQnty;
            bool resultOfTryParse;

            do
            {
                Console.WriteLine("How many products wil you want to buy?");
                string typedNumber = Console.ReadLine();
                resultOfTryParse = uint.TryParse(typedNumber, out productQnty);
            } while (!resultOfTryParse);

            double totalPrice = productQnty * prodObj.Price;


            Console.ReadKey();
        }
    }
}
