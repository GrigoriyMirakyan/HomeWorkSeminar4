/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

int GetNumber(string msg) //функция считывающая введенное число + проверка что число является числом)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;

        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int digitSum(int number)  //функция, считающая сумму цифр в числе
{
    int digit = 0;
    int result = 0;
    while (number > 9)
    {
        digit = number % 10;
        number = number / 10;
        result = result + digit;
    }
    result = result + number;
    return result;
}

int number = GetNumber("Введите число: ");
int result = digitSum(number);
Console.WriteLine($"{number} -> {result}");
Console.ReadKey();
