using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Попов";
            string lastName = "Алексей";
            string reserve;

            Console.WriteLine("До исправления");
            Console.WriteLine("Имя : " + firstName);
            Console.WriteLine("Фамилия : " + lastName);
            reserve = firstName;
            firstName = lastName;
            lastName = reserve;
            Console.WriteLine("После исправления");
            Console.WriteLine("Имя : " + firstName);
            Console.WriteLine("Фамилия : " + lastName);
        }
    }
}
