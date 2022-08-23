// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом. Задача19
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber( string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Введенное число: {number} - палиндром");
  }
  else Console.WriteLine($"Введенное число: {number} - не палиндром");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
