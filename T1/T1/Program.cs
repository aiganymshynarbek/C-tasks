Console.WriteLine("Введите первое число:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите операцию:");
char operation = Console.ReadLine()[0];

switch (operation)
{
    case '+':
        Console.WriteLine($"Результат: {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"Результат: {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"Результат: {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
        {
            Console.WriteLine($"Результат: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Нельзя делить на 0");
        }
        break;
    default:
        Console.WriteLine("Недопустимая операция. Введите +, -, *, или /.");
        break;
}
