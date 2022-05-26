/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

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

int x = GetNumber("Введите число A:");
int stepen = GetNumber("Введите степень B, в которую требуется возвести число: ");

Console.WriteLine("A^B = " + Math.Pow(x, stepen));

Console.ReadKey();

//сделал максимально просто... на лекции говорили, чем проще решение тем лучше)) Лень - двигатель программирования