
while (true)
{
    Console.WriteLine("Выберете игру: ");
    Console.WriteLine("1) Угадай число");
    Console.WriteLine("2) Таблица умножения");
    Console.WriteLine("3) Вывод делителей числа");
    Console.WriteLine("4) Выход");
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Random random = new Random();
            int b = random.Next(0, 100);
            string input;
            Console.WriteLine("Угадай число от 1 до 100");
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) > b)
                    Console.WriteLine("Ваше число больше");
                if (int.Parse(input) < b)
                    Console.WriteLine("Ваше число меньше");

            }
            while (int.Parse(input) != b);
            Console.WriteLine("Вы победили");
            break;

        case 2:
            int[,] table = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    table[i, j] = i * j;
                    Console.Write("  ", table[i, j]);
                }
                Console.WriteLine();
                
            }
            break;

        case 3:

            Console.WriteLine("Поиск делителей числа");
            string z = Console.ReadLine().ToLower();
            int number = Convert.ToInt32(z);
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            break;

        case 4:
            Environment.Exit(0);
            break;

    }
}
