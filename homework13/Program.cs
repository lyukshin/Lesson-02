// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());




int digit1 = number%100;
int digit2 = digit1/10;


Console.WriteLine($"Итоговое число: {digit2}");