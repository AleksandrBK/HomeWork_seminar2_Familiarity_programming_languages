// int number;
// int secondDigit;

// while (true)
// {
//     Console.Write("Введите трехзначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());

//     if (number >= 100 && number < 1000)
//     {
//         secondDigit = (number % 100) / 10;
//         break; 
//     }

//     Console.WriteLine($"Вы ввели не трехзначное число >{number}<, пожалуйста, повторите попытку");
// }

// Console.WriteLine($"Вторая цифра введенного числа: {secondDigit}");

int number;
int secondDigit;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Вы не ввели число, пожалуйста повторите попытку");
        continue; 
    }

    if (!int.TryParse(input, out number))
    {
        Console.WriteLine("Вы ввели некорректное значение, пожалуйста повторите попытку");
        continue; 
    }

    if (number < 100 || number >= 1000)
    {
        Console.WriteLine($"Вы ввели не трехзначное число >{number}<, пожалуйста повторите попытку");
        continue; 
    }

    secondDigit = (number % 100) / 10;
    break; 
}

Console.WriteLine($"Вторая цифра введенного числа: {secondDigit}");