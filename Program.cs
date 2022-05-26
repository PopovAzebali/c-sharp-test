using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string age;
            string hairColor;
            string eyeColor;
            string height;

            Console.WriteLine("Как Вас зовут :");
            myName = Console.ReadLine();

            Console.WriteLine("Сколько Вам полных лет :");
            age = Console.ReadLine();

            Console.WriteLine("Какого цвета у Вас волосы :");
            hairColor = Console.ReadLine();

            Console.WriteLine("Какого цвета у Вас глаза :");
            eyeColor = Console.ReadLine();

            Console.WriteLine("Укажите Ваш рост :");
            height = Console.ReadLine();

            Console.WriteLine("Получается, что Вас зовут " + myName + '.' + " Вам " + age + " лет. " + " Волосы " + hairColor + " ,глаза " + eyeColor + " , рост " + height);
           
        }
    }
}
