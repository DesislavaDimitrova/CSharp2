using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit playerOne = new Unit(10, 37, 40, "PlayerOne");
            Unit playerTwo = new Unit(110, 20, 15, "PlayerTwo");

            while(!playerOne.IsDead && !playerTwo.IsDead)
                {
                Console.WriteLine("First player's turn. Choose an action: ");
                string choice = Console.ReadLine();

                if (choice == "attack")
                {
                    playerOne.Attack(playerTwo);
                }
                else
                {
                    playerOne.Heal();
                }

                if (playerOne.IsDead || playerTwo.IsDead)
                    break;

                Console.WriteLine($"Heatlh: {playerOne.UnitName} = {playerOne.Health} {playerTwo.UnitName} = {playerTwo.Health}");

                Console.WriteLine("Second player's turn. Choose an action: ");
                choice = Console.ReadLine();

                if (choice == "attack")
                {
                    playerTwo.Attack(playerOne);
                }
                else
                {
                    playerOne.Heal();
                }

                Console.WriteLine($"Heatlh: {playerOne.UnitName} = {playerOne.Health} {playerTwo.UnitName} = {playerTwo.Health}");
            }
        }
    }
}
