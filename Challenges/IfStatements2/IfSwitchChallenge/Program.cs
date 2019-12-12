using System;

namespace IfSwitchChallenge
{
    class Program
    {

        static int highscore = 300;
        static string highscorePlayer = "Oli";
        static void Main(string[] args)
        {
            CheckHighscore(250, "Bill");
            CheckHighscore(325, "Hugh Anus");
            CheckHighscore(400, "Oli");

            Console.Read();

        }

        public static void CheckHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be beaten, it is still " + highscore + " and is held by " + highscorePlayer);
            }
        }

    }
}
