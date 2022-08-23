// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N. Задача 23
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();
WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());

for(int i=1; i<=n; i++) 
{
    Write($"{Math.Pow(i,3)} ");
  
}
