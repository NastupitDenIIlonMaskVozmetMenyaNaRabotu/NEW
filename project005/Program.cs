// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
Console.WriteLine("Напишите количество чисел в массиве:");
int ArrayCount=int.Parse(ReadLine());
int[] Array = GetArray(ArrayCount);
Console.WriteLine($"{String.Join(" ", Array)}");
Console.WriteLine($"Количество четных чисел в массиве {GetPositiveCount(Array)}");


int[] GetArray(int count)
{
    int[] result=new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i]=new Random().Next(100, 1000);
    }
    return result;
}

int GetPositiveCount(int[] massive)
{
    int PositiveCount = 0;
for (int i = 0; i < massive.Length; i++)
    {   
        PositiveCount+=massive[i]%2==0? 1:0;
    }
    return PositiveCount;
}


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Clear();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях:");
Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");

      if (i % 2 == 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] newarray = new double[10]; 
void FillArray(double[]collection) 
{
     for(int i = 0; i < collection.Length; i++)
    { 
        collection[i] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble() , 1);
    }
}    
void PrintArray(double[] array)   
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]};  ");
    Console.WriteLine();
}
void PrintDifferenceMinMaxElements(double[] array)
{
    double min =  array[0]; 
    double max =  array[0]; 
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {                                      
        if (i == 0) 
        Console.Write("[");
        if (i < array.Length - 1)
        Console.Write(array[i] + ", ");
        else 
        Console.Write(array[i] + "]");
    }
    result = max - min;

    Console.WriteLine($"Значение минимального элемента: {min} ");
    Console.WriteLine($"Значение максимального элемента: {max} ");
    Console.WriteLine($"Разница между максимальным и минимальным значениями элементов = {result} ");
}

FillArray(newarray);
Console.WriteLine();
PrintArray(newarray);
Console.WriteLine();
PrintDifferenceMinMaxElements(newarray);