using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int album = 52;
            int row = 3;
            int fullRow;
            int excess;

            fullRow = album / row;

            Console.WriteLine("Количество полных рядов по 3 картинки = " + fullRow);

            excess = album - (fullRow * row);

            Console.WriteLine("Количество избытка = " + excess + " картинка");

        }
    }
}
