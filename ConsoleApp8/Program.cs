
while (true)
{
    Random tan = new Random();
    int a = tan.Next(0, 100);
    int b;
    b = Convert.ToInt32(Console.ReadLine());
    if (b != a)
    {
        Console.WriteLine("Вы ввели неверное число, введите другое");
       
    }
    else
    {
        Console.WriteLine("Победа");
        break;
    }




}

