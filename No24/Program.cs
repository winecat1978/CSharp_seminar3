// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 (1+2+3+4+5+6+7)
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int num))
        {
            if (num > 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Вы ввели не натуральное число. Попробуйте еще раз!");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Попробуйте еще раз!");
        }
    }
}

int SummaryOfNumbers(int A)
{
    int count = 1;
    int result = 0;
    do
    {
        result = result + count;
        count++;
    }
    while (A >= count);
    return result;
}

string message = "Введите натуральное число.";
int A = GetNumber(message);
int Summ = SummaryOfNumbers(A);
Console.WriteLine($"{A} -> {Summ}");
