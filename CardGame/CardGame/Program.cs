using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.BL;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Enter 1 to play the game: ");
                Console.WriteLine("Enter 2 to exit the game: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();


                if (option == 1)
                {
                    bool gameRunning = true;
                    int score = 0;

                    BL.Deck obj = new BL.Deck();
                    obj.shuffle();

                    BL.Card card1 = obj.dealCard();

                    while (gameRunning)
                    {
                        int remainCheck = obj.cardsLeft();
                        BL.Card card2 = obj.dealCard();
                        Console.WriteLine("************************");
                        Console.WriteLine(card1);
                        Console.WriteLine("");
                        Console.WriteLine("Remaining Cards" + remainCheck);
                        Console.WriteLine("Enter 1 if next card is higher: ");
                        Console.WriteLine("Enter 2 if next card is lower: ");

                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (card_check == 1)
                        {
                            if (card2.getValue() > card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }

                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry you lose! Press any key to continue: ");
                                Console.WriteLine("The card was " + card2);
                                Console.WriteLine("Your Score is : " + score);
                                Console.ReadKey();
                                Console.Clear();

                                

                            }

                        }
                        if (card_check == 2)
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry you lose! Press any key to continue: ");
                                Console.WriteLine("The card was " + card2);
                                Console.WriteLine("Your Score is : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        if (obj.cardsLeft() == 0 && card2 == null)
                        {
                            gameRunning = false;
                            Console.WriteLine("Congrats! You have scored maximum");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    }

                }

            } while (option != 2);
        }
    }

}
