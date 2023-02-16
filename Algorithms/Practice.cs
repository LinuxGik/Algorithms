using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Practice
    {
        public static void GameBones()
        {
            // Дополнение к разделу "Добавление логики принятия решений в код с помощью операторов if, else и else if в C#".
            Console.WriteLine("Если значение двух костей совпадают: +2 премиальных балла\nЕсли занчение трех костей совпадает: +6 премиальных баллов");
            Console.WriteLine("Если сумма всех трех костей и бонусов не меньше 15 вы выигрываете. В противном случае вы проиграли.");

            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice rooll: {roll1} + {roll2} + {roll3} = {total}");
        }
    }
}
