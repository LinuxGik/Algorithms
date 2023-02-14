using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class StoringAndRetrievingData
    {
        // По "схеме обучения" Microsof.Lern: Работа с данными
        public static void DataTypes()
        {
            Console.WriteLine("Существуют две основные категории типов данных: типы значений и ссылочные типы.");
            Console.WriteLine("Простые типы значений — это набор предопределенных типов, которые предоставляются в C# в виде ключевых слов.");

        }

        // По "схеме обучения" Microsof.Lern: Хранение и извлечение данных с использованием значений, представленных литералами и переменными
        public static void StorAndRetriev()
        {
            Console.WriteLine("Хранение и извлечение данных с использованием значений, представленных литералами и переменными");
            Console.WriteLine("\nЛитеральное значение — это жестко задаваемое значение, которое не может быть изменено.\n");
            Console.WriteLine("1. Если вам нужно вывести на экран одну букву или цифру, следует создать символьный литерал, заключив нужный символ в одинарные кавычки.");
            Console.WriteLine("Console.WriteLine('b');\t используется тип char\n");
            Console.WriteLine("2. Вывод целочисленного литерала на консоль.\nConsole.WriteLine(123); (тип int)\n");
            Console.WriteLine("3. Вывод десятичного литерала на консоль.\nConsole.WriteLine(12.30m);\nПример что будет если вывести без литерального суффикса m: ");
            Console.WriteLine("Код: Console.WriteLine(12.30);\tрезультат: " + 12.30);
            Console.WriteLine("Без литерального суффикса m десятичное число будет рассматриваться компилятором как значение типа double, поэтому выходные данные 12.3 а не 12.30");
           
        }

        public static void LiteralSuffixes()
        {
            Console.WriteLine("Литеральные суффиксы");
            Console.WriteLine("cуффикс\tтип");
            Console.WriteLine("M/m\tdecimal");
            Console.WriteLine("F/f\tfloat");
            Console.WriteLine();
            Console.WriteLine("U/u\tuint\nL/l\tlong\nUL/ul/LU\tulong");
        }
    }
}
