using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Turn
    {
        public static void TurnOne()
        {
            Die diceOne = new Die();
            Die diceTwo = new Die();

            int p1 = diceOne.FaceValue;
            int p2 = diceTwo.FaceValue;

            Console.WriteLine("player one score is {0}. player two score is {1}", p1, p2);
        }


        public static void AdvTurn()
        {
            Die diceOne = new Die(20, "Black");
            Die diceTwo = new Die(20, "Black");

            int p1 = diceOne.FaceValue;
            int p2 = diceTwo.FaceValue;

            Console.WriteLine("player one score is {0}. player two score is {1}", p1, p2);
        }
    }
}
