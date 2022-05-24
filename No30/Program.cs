// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection) // функция, заполняющая массив
{
    Random Randomiser = new Random(); // объявили класс рандом до цикла
    for(int i=0; i<collection.Length; i++)
    {
        collection[i] = Randomiser.Next(0,2);
    }
}

int[] array = new int[8]; // задали массив и его длину
FillArray(array); // вызвали функцию
for(int i=0; i<array.Length; i++)
{
    Console.Write(array[i] + " ");
}
