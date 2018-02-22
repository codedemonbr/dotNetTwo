using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Caixa
    {
        /*
         * Caixa means cash register.
         * Let me introduce you the trouble.
         * When the cash register we do not have coins and just banknotes
         * Nota means banknotes
         */

        //inicialized part
        private int nota20 = 50;//[9]
        private int nota10 = 50;//[8]
        private int nota5 = 50;//[7]
        private int nota2 = 50;//[6]
        private int nota1 = 50;//[5]
        private int halfCoin = 0;//US$0,50//[4]
        private int quarterCoin = 0;//US$0,25//[3]
        private int dimmeCoin = 0;//US$0,10//[2]
        private int nickelCoin = 0;//US$0,05//[1]
        private int pennyCoin = 0;//US$0,01//[0]

        private double saldoCaixa;//this instance variable means cash balance; Saldo = balance

        /*
         * tool  number 18 is a code that means lack of change if true
         * 
         */
        public bool tool18;

        public void CalculaSaldo()
        {
            /*
             * This method calculate de balance of the cash register
             */
            double centsPart = (halfCoin * 0.5) + (quarterCoin * 0.25) + (dimmeCoin * 0.1) + (nickelCoin * 0.05) + (pennyCoin * 0.01);
            saldoCaixa = nota10 * 10 + nota2 * 2 + nota20 * 20 + nota5 * 5 + nota1 + centsPart;

        }

        private double MoneyDelivered(int[] receivedMoney)
        {
            /*
             * the order is important because the value is multplied by weight
             * this method decomposes and computes the value delivered and received in cash in the transaction
             */
            double centsPart = (receivedMoney[4] * 0.5) + (receivedMoney[3] * 0.25) + (receivedMoney[2] * 0.1) + (receivedMoney[1] * 0.05) + (receivedMoney[0] * 0.01); ;
            double banknotePart = receivedMoney[8] * 10 + receivedMoney[6] * 2 + receivedMoney[9] * 20 + receivedMoney[7] * 5 + receivedMoney[5];
            double total = centsPart + banknotePart;//this variable is not so necessary, but I prefer this cumbersome way to facility the debug view. You can refactory or simplify it.
            return total;
        }

        public void CalculateChange(double price, int[] format)
        {
            double receivedMoney = MoneyDelivered(format);
            if (receivedMoney == price)
            {
                Console.WriteLine("Good no change at this transaction");

            }
            else if (receivedMoney > price)
            {
                Console.WriteLine("Verification if we have correct change is needed");
            }
            else
            {
                Console.WriteLine("Client money back, because there is no enough money. Try later");
            }
            this.pennyCoin += format[0];

        }

        public double SaldoCaixa
        {
            get
            {
                CalculaSaldo();
                return saldoCaixa;
            }
            set { saldoCaixa = value; }
        }

        public Caixa()
        {
            CalculaSaldo();
        }
    }
}
