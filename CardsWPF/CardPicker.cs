using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWPF
{
    internal class CardPicker
    {

        static Random random= new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i =0; i <numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }


        public static string RandomSuit()
        {
            //pobieranie liczby losowej
            int value = random.Next(1, 5);
            // 1 - pik
            if (value == 1) return "pik";
            //2 - kier
            if (value == 2) return "kier";
            //3 - trefl
            if (value == 3) return "trefl";
            // karo
            return "karo";
        }

        public static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "As"; 
            if (value == 11) return "Walet"; 
            if (value == 12) return "Dama"; 
            if (value == 13) return "Krol";
            return value.ToString(); // pozostale karty 2-10

        }


    }
}
