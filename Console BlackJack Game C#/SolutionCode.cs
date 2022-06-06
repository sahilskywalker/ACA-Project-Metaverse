using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
	class Program
	{
		static void Main(string[] args)
		{
            const double rupay=10000.00;
            Console.WriteLine("\n     BLACKJACK  GAME    ");
            string player;
            Console.Write(" \nenter your name : ");
            player=Console.ReadLine();
            Console.WriteLine("\n\nWelcome  {0}",player);
            Console.Write("Money Available  : {0}",rupay);
            Console.WriteLine("\n\nChoose the options\n");
            Console.WriteLine("  1. New Game");
            Console.WriteLine("  2. exit ");
            Console.Write("\nchoice is  : ");
            string choice;
            choice=Console.ReadLine();
            switch(choice)
            {
                case "1" : var randomcardgenerator=new Random();
                           var firstcardscore=randomcardgenerator.Next(1, 10);
                           var secondcardscore=randomcardgenerator.Next(1, 10);
                           var thirdcardscore=0;

                           Console.WriteLine("first card score : {0}",firstcardscore);
                           Console.WriteLine("\nsecond card score : {0}",secondcardscore);
                           Console.WriteLine("\nyou want third card ???\n");
                           Console.WriteLine("   1. YES");
                           Console.WriteLine("   2. NO");
                           Console.Write("\nchoice is  : ");
                           string choice1;
                           choice1=Console.ReadLine();
                           if (choice1 == "1")
                           {
                                thirdcardscore = randomcardgenerator.Next(1, 10);
                                Console.WriteLine("\nthird card score : {0}",thirdcardscore);
                           }

                           var totalcardscore = firstcardscore + secondcardscore + thirdcardscore;
                           Console.WriteLine("\nTotal score : {0}",totalcardscore);

                           if (totalcardscore > 21)
                           {
                                Console.WriteLine("\nGame over ......\n\n");
                                return;
                           }

                           var dealercardscore = randomcardgenerator.Next(10, 21);

                           Console.WriteLine("\ndealer card score : {0}",dealercardscore);

                           if (totalcardscore <= dealercardscore)
                           {
                               Console.WriteLine("\nDealer won  Game over ...\n\n");
                               return;
                           }

                           Console.WriteLine("\nCongrates\nYou won ...\n\n");
                           return;
                case "2" : Console.WriteLine("\nExiting game ");
                           return;

            }
		}
	}
}





