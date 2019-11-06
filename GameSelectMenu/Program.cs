using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have these games available today: 1: Robber 2: Guild Manager 3: Platformer");
            GameSelectClass gameSelect = new GameSelectClass();
            gameSelect.GameSelectMenu();
        }
    }
    class GameSelectClass
    {
        public void GameSelectMenu()
        {
            int gameNum = int.Parse(Console.ReadLine());

            switch (gameNum)
            {
                case 1:
                    Console.WriteLine("Welcome to Robber");
                    break;

                case 2:
                    Console.WriteLine("Welcome to Guild Manager");
                    break;

                case 3:
                    Console.WriteLine("Welcome to my Platformer");
                    break;

                default:
                    Console.WriteLine("Please select a game from the list");

                    break;
            }


        }
        public class GameException
        {
            int playerInput;

            GameException()
            {
                playerInput = 4;
            }
            public void Selection(int num1)
            {
                try
                {
                    playerInput = num1;
                    throw (new ArgumentOutOfRangeException("Exception"));
                }
                catch (Exception outOfRange)
                {
                    Console.WriteLine("Exception caught: {0}", outOfRange);

                }
                finally
                {
                    Console.WriteLine("Result: {0}", playerInput);
                }
            }
            // Need to incorporate into switch case
            // Also make format exception message

            public int Enemy(int enemyInGame)
            {
                enemyInGame = 1;
                return enemyInGame;
            }
            public string EnemyTitle(string enemyName)
            {
                enemyName = "Enemy 1";
                return enemyName;
            }
        }


    }

}

