// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

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

int CountMultiplication (int N)
{
    int count = 1;
    int result = 1;
    do
    {
        result = result * count;
        count ++;
    } while(count <= N);
    return result;
}


string message = "Введите натуральное число: ";
int N = GetNumber(message);
int Multiplication = CountMultiplication(N);
Console.WriteLine($"{N} -> {Multiplication}");
