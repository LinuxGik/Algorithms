using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class StoringAndRetrievingData
    {
        public static void Beginer()
        {
            // метод Beginer вызывет главное меню программы
            byte razdel;
            Console.WriteLine("Это обучаяща программа по язаку С#");

            // Начальная часть, со списком разделов для выбора раздела
            Console.WriteLine("Выберите раздел: ");
            Console.WriteLine("1. Работа с данными\n2. Хранение и извлечение данных с использованием значений, представленных литералами и переменными" +
                "\n3. Добавление логики принятия решений в код с помощью операторов if, else и else if в C#");

            // Выбор раздела
            razdel = Convert.ToByte(Console.ReadLine());

            switch (razdel)
            {
                case 1:
                    StoringAndRetrievingData.DataTypes();
                    break;
                case 2:
                    StoringAndRetrievingData.StorAndRetriev();
                    break;
                case 3:
                    StoringAndRetrievingData.DecisionLogic();
                    break;
            }
        }


        static void EndOreBegine()
        {
            // Метод EndOreBegin возвращает в главное меню или заканчивает программу
            Console.Write("\nПерейти в главное меню или выйти из программы? (да - продолжить в главном меню/ нет - выйти): ");
            string eOb = Console.ReadLine();
            if (eOb == "да")
            {
                Beginer();
            }
        }
       
        public static void DataTypes()
        {
            // По "схеме обучения" Microsof.Lern: Работа с данными
            Console.WriteLine("\nСуществуют две основные категории типов данных: типы значений и ссылочные типы.");
            Console.WriteLine("Простые типы значений — это набор предопределенных типов, которые предоставляются в C# в виде ключевых слов.");
            EndOreBegine();
        }

        public static void StorAndRetriev()
        {
            // По "схеме обучения" Microsof.Lern: Хранение и извлечение данных с использованием значений, представленных литералами и переменными

            Console.WriteLine("\nХранение и извлечение данных с использованием значений, представленных литералами и переменными");
            Console.WriteLine("\nЛитеральное значение — это жестко задаваемое значение, которое не может быть изменено.\n");
            Console.WriteLine("1. Если вам нужно вывести на экран одну букву или цифру, следует создать символьный литерал, заключив нужный символ в одинарные кавычки.");
            Console.WriteLine("Console.WriteLine('b');\t используется тип char\n");
            Console.WriteLine("2. Вывод целочисленного литерала на консоль.\nConsole.WriteLine(123); (тип int)\n");
            Console.WriteLine("3. Вывод десятичного литерала на консоль.\nConsole.WriteLine(12.30m);\nПример что будет если вывести без литерального суффикса m: ");
            Console.WriteLine("Код: Console.WriteLine(12.30);\tрезультат: " + 12.30);
            Console.WriteLine("Без литерального суффикса m десятичное число будет рассматриваться компилятором как значение типа double, поэтому выходные данные 12.3 а не 12.30");
            EndOreBegine();
        }

        public static void DecisionLogic()
        {
            // По модулю Microsoft.Lern: Добавление логики принятия решений в код с помощью операторов if, else и else if в C# 
            Console.WriteLine("\nДобавление логики принятия решений в код с помощью операторов if, else и else if в C#");
            Console.WriteLine("Запустить игру Кости? (да/нет): ");
            string DaNet = Console.ReadLine();
            if (DaNet == "да")
            {
                Practice.GameBones();
            }
            EndOreBegine();
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
