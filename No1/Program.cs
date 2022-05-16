// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
       return 1;
    }
    else if (x < 0 && y > 0)
    {
        return 2;
    }
    else if (x < 0 && y < 0)
    {
          return 3;
    }
    else return 4;
}

int GetNumber(string msg) // функция получает число с клавиатуры + проверка на ввод именно числа и число не ноль
{
  while(true) // бесконечный цикл 
   {
     Console.WriteLine(msg);
     string valueFromConsole = Console.ReadLine();

       if (int.TryParse(valueFromConsole, out int number)) // преобразовали одну переменную в другую 
      {
        if (number != 0) // не равно 
            return number;
        else
        {
            Console.WriteLine("Число должно отличаться от нуля!");
        }
      } 
       else 
       {
           Console.WriteLine("Вы ввели не число. Введите число, отличное от нуля.");
       }
    }
}
string messageX = "Введите число х: ";
string messageY = "Введите число y: ";

int x = GetNumber(messageX);
int y = GetNumber(messageY);

int quater = GetQuarter(x,y);

Console.WriteLine($"точка лежит в {quater} четверти ");