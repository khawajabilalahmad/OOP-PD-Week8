using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.BL;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Deck deck = new Deck();
                BlackjackHand player = new BlackjackHand();
                BlackjackHand dealer = new BlackjackHand();

                // Initial deal
                player.addCard(deck.dealCard());
                player.addCard(deck.dealCard());
                dealer.addCard(deck.dealCard());
                dealer.addCard(deck.dealCard());

                Console.WriteLine("Player's Hand:");
                player.ShowHand();
                Console.WriteLine("Player Score: " + player.getBlackJackValue());

                Console.WriteLine("\nDealer shows: " + dealer.GetHand()[0]);

                // Player Turn
                while (player.getBlackJackValue() < 21)
                {
                    Console.Write("\nHit or Stand? ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "hit")
                    {
                        player.addCard(deck.dealCard());
                        Console.WriteLine("Player's Hand:");
                        player.ShowHand();
                        Console.WriteLine("Player Score: " + player.getBlackJackValue());
                    }
                    else
                        break;
                }

                if (player.IsBusted())
                {
                    Console.WriteLine("\nPlayer busted! Dealer wins.");
                    return;
                }

                // Dealer Turn
                Console.WriteLine("\nDealer's Hand:");
                dealer.ShowHand();
                Console.WriteLine("Dealer Score: " + dealer.getBlackJackValue());

                while (dealer.getBlackJackValue() < 17)
                {
                    Console.WriteLine("Dealer hits.");
                    dealer.addCard(deck.dealCard());
                    Console.WriteLine("Dealer's Hand:");
                    dealer.ShowHand();
                    Console.WriteLine("Dealer Score: " + dealer.getBlackJackValue());
                }

                if (dealer.IsBusted())
                {
                    Console.WriteLine("\nDealer busted! Player wins.");
                }
                else
                {
                    // Final comparison
                    int playerScore = player.getBlackJackValue();
                    int dealerScore = dealer.getBlackJackValue();

                    Console.WriteLine($"\nFinal Scores => Player: {playerScore}, Dealer: {dealerScore}");

                    if (playerScore > dealerScore)
                        Console.WriteLine("Player wins!");
                    else if (dealerScore > playerScore)
                        Console.WriteLine("Dealer wins!");
                    else
                        Console.WriteLine("It's a tie!");
                }
            }
        }
}

