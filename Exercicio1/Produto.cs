using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    /*
     * Sorry! I am from Brazil and I forgot to use English here. And I do not want to restart the work.
     * To be clear Produto means product.
     */
    class Produto
    {
        private string name;
        private float price;
        private uint code;

        public Produto()
        {
            /*
             *The constructor will asign the values for itself propert.
             * Just type the values correctly and enjoy the show.
             * This class was made by example. Is not a professional class, just for fun.
             */
            Console.WriteLine("Enter with the name of product");
            this.name = Console.ReadLine();//No validations for name of product. Be free to add this disarable funcionality
            bool gottchaValue;
            do
            {
                /*
                 * But here we need validate if we have correcty values
                 */
                Console.WriteLine("Type a  #MAGA price US$");
                string typedPrice = Console.ReadLine();
                gottchaValue = float.TryParse(typedPrice, out this.price);
            } while (!gottchaValue);

            /*
             * I was researching a way to clear the console window
             * And the line below do it for us;
             */
            Console.Clear();

            do
            {
                /*
                 * But here we need validate if we have correcty values
                 * If you have a couple of minutes, please refactory this code
                 * The code here is repeated. 
                 */
                Console.WriteLine("Type a valid code");
                string typedPrice = Console.ReadLine();
                gottchaValue = uint.TryParse(typedPrice, out this.code);//uint will never be a negative number
            } while (!gottchaValue);

            Console.Clear();

        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public uint Code { get => code; set => code = value; }
    }
}
