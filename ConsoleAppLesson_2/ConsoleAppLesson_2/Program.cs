using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string secondNumber = Console.ReadLine();
            // метод Parse осуществляет тоже самое что и метод Convert, но этот метод работает исключительно со строками
            // т.е. преобразовывает строки в другие типа данных, а метод Convert может и другие типы данных преобразовывать в строки
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            Console.WriteLine("Sum of these numbers is - " + (a + b));
            Console.WriteLine("Enter the wrong number");
            string wrongNumber = Console.ReadLine();
            int c;
            // метод TryParse анлогичен конструкции Try/Catch, но для конвертирования строки в указанный тип. Если строка содержит неверное значение,
            // то в результате в пременную запишеться 0 или вернуться false:
            // например если мы хотим привести строку "25asdasd" в тип int и записать значение в переменную 'c', то в переменную запишеться 0, а метод вернут false
            bool resultTryParse = int.TryParse(wrongNumber, out c);
            if (c != 0 && resultTryParse == true)
            {
                Console.WriteLine("You entered the correct number. Your number is " + c);
            }
            else
            {
                Console.WriteLine("You entered the wrong number");
            }
        }
    }
}
