// Напишите прогу, которая выдает число цифр в числе

string GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse (ValueFromConsole, out int num))
        {
            return ValueFromConsole;
        }
        else 
        {
            Console.WriteLine("Вы ввели не число. Попробуйте еще раз!");
        }
    }
}

int CountNum (string str)
{
  return str.Length;
}


string message = "Bведите число: ";
string str = GetNumber(message);
int countnum = CountNum(str);
Console.WriteLine($"{str} -> {countnum}");
