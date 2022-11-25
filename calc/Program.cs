string x = @"Какое действие вы хотите выполнить? (укажите номер желаемого дейтсвия)
1)Сложение(доступно любое количество переменных)
2)Вычитание(только 2 переменные)
3)Умножение(доступно любое количество переменных)
4)Деление(только 2 переменные)
5)Возведение в степень(только 2 переменные)
6)квадратный корень из числа(только 1 переменная)
";
Console.WriteLine(x);
string a = Console.ReadLine();

if (a=="1"){
    Console.WriteLine("Сколько вы хотите ввести переменных?");
    short y = Convert.ToInt16(Console.ReadLine());
    int summ = 0;
    for (short i = 1; i <= y; i++)
    {
        Console.WriteLine("***********");
        Console.WriteLine("Введите {0} переменную", i);
        int g = Convert.ToInt32(Console.ReadLine());
        summ+= g;
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Текущая сумма: {0}", summ);
        Console.ForegroundColor = prevColor;
    }
}
else if (a == "2")
{   
    Console.WriteLine("Введите уменьшаемое ");
    int x_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите вычитаемое ");
    int x_2 = Convert.ToInt32(Console.ReadLine());
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ваша разность: {0}", x_1-x_2);
    Console.ForegroundColor = prevColor;
}
else if (a == "3")
{
    Console.WriteLine("Сколько вы хотите ввести переменных?");
    short y = Convert.ToInt16(Console.ReadLine());
    int prov = 1;
    for (short i = 1; i <= y; i++)
    {
        Console.WriteLine("***********");
        Console.WriteLine("Введите {0} переменную", i);
        int g = Convert.ToInt32(Console.ReadLine());
        prov*= g;
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Текущие произведение: {0}", prov);
        Console.ForegroundColor = prevColor;
    }
}
else if (a == "4")
{
    Console.WriteLine("Введите делимое");
    float x_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите делитель");
    float x_2 = Convert.ToInt32(Console.ReadLine());
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ваше частность: {0}", x_1/x_2);
    Console.ForegroundColor = prevColor;
}
else if (a == "5")
{
    Console.WriteLine("Введите число, которое будем возводить");
    int x_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень");
    int x_2 = Convert.ToInt32(Console.ReadLine());
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ваше число: {0}", Math.Pow(x_1,x_2));
    Console.ForegroundColor = prevColor;
}
else if (a == "6")
{
    Console.WriteLine("Введите число, из которого будем получать корень");
    int x_1 = Convert.ToInt32(Console.ReadLine());
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ваш корень: {0}", Math.Sqrt(x_1));
    Console.ForegroundColor = prevColor;
}