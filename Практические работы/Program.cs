using System.Runtime.ExceptionServices;

string fickus = "";

while (fickus != "9")
{
    Console.Write("Выберите действие из представленных ('+','-','*','/','^','квадратный корень','1%','факториал'), если хотите выйти из программы напишите 9 : ");
    fickus = Console.ReadLine();

    if (fickus == "+")
    {
        Console.Write("Введите первое число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число : ");
        double second_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(first_number + second_number);
    }
    else if (fickus == "-")
    {
        Console.Write("Введите первое число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число : ");
        double second_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(first_number - second_number);
    }
    else if (fickus == "*")
    {
        Console.Write("Введите первое число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число : ");
        double second_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(first_number * second_number);
    }
    else if (fickus == "/")
    {
        Console.Write("Введите первое число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число : ");
        double second_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(first_number / second_number);
    }
    else if (fickus == "^")
    {
        Console.Write("Введите первое число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число : ");
        double second_number = Convert.ToDouble(Console.ReadLine());

        double N = first_number;
        for (int i = 1; i < second_number; i++)
        {
            first_number *= N;
        }
        Console.WriteLine(first_number);
    }
    else if (fickus == "квадртаный корень")
    {
        Console.Write("Введите число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(Math.Sqrt(first_number));
    }
    else if (fickus == "1%")
    {
        Console.Write("Введите число : ");
        double first_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(first_number * 0.01);
    }
    else if (fickus == "факториал")
    {
        Console.Write("Введите число : ");
        int first_number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < first_number; i++)
        {
            first_number *= i;
        }
        Console.Write(first_number);
    }
    else if (fickus == "9")
    {
        Console.WriteLine("бб.");
    }
    else
    {
        Console.WriteLine("Введенного вами действия нету в списке. Можете уходить.");
    }
}