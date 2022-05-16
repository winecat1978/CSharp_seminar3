// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// получить коордианты х и у 1 и 2 точки - вставить их в формулу и вывести расстояние

int GetDot(string msg) // функция получает координаты с клавиатуры 
{
    while (true)
    {
        Console.WriteLine(msg);
        string numFromConsole = Console.ReadLine();

        if (int.TryParse(numFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число");
        }
    }

}

double GetDistance(double x1, double y1, double x2, double y2) // функция считает расстояние 
{
   double difx = Math.Pow((x1-x2), 2);
   double dify = Math.Pow((y1-y2), 2);
   double res = Math.Sqrt(difx + dify);
   return res;
}

string messageX = "Введите число х1: ";
string messageY = "Введите число y1: ";
string messageZ = "Введите число х2: ";
string messageU = "Введите число y2: ";

int x1 = GetDot(messageX);
int y1 = GetDot(messageY);
int x2 = GetDot(messageZ);
int y2 = GetDot(messageU);

double Result = GetDistance(x1, x2, y1, y2);
Console.WriteLine($"расстояние между точками А({x1};{y1}) и В({x2};{y2}) равно {Result}");
