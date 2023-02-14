using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte razdel;
            Console.WriteLine("Это обучаяща программа по язаку С#");
            Console.WriteLine("Выберите раздел: ");
            StoringAndRetrievingData.StorAndRetriev();
            StoringAndRetrievingData.LiteralSuffixes();
        }
    }
}
