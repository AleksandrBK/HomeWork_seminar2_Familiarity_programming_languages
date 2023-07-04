Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine($"Вы ввели не трехзначное число >{number}< пожалуйста повторите попытку");
    return;
}

int secondDigit = (number % 100) / 10;

Console.WriteLine($"Вторая цифра введенного числа: {secondDigit}");
