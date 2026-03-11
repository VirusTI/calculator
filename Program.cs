using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        Console.WriteLine("Доступные операции: +  -  *  /");
        Console.WriteLine("Для выхода введите q");

        while (true)
        {
            Console.Write("\nВведите первое число: ");
            string? input1 = Console.ReadLine();

            if (input1?.Trim().ToLower() == "q")
                break;

            input1 = input1?.Replace(',', '.');

            if (!double.TryParse(input1, NumberStyles.Any, CultureInfo.InvariantCulture, out double num1))
            {
                Console.WriteLine("Ошибка: первое значение не является числом.");
                continue;
            }

            Console.Write("Введите второе число: ");
            string? input2 = Console.ReadLine();

            if (input2?.Trim().ToLower() == "q")
                break;

            input2 = input2?.Replace(',', '.');

            if (!double.TryParse(input2, NumberStyles.Any, CultureInfo.InvariantCulture, out double num2))
            {
                Console.WriteLine("Ошибка: второе значение не является числом.");
                continue;
            }

            Console.Write("Введите операцию (+, -, *, /): ");
            string? operation = Console.ReadLine();

            if (operation?.Trim().ToLower() == "q")
                break;

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {num1 / num2}");
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка: неизвестная операция.");
                    break;
            }
        }

        Console.WriteLine("Программа завершена.");
    }
}