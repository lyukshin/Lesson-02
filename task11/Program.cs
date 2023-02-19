// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
// 

int number = new Random().Next(100, 1000); //
Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number/10;
int digit2 = number%10;

if(digit1 > digit2)
{
    Console.Write($"Наибольшая цифра числа: {digit1}");
}
else if (digit2 > digit1)
{
    Console.Write($"Наибольшая цифра числа: {digit2}");
}
else
{
    Console.Write($"Цифры равны");
}

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000); 
Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number/100;
int digit2 = number%10;
int digit3 = digit1 * 10 + digit2;

Console.WriteLine($"Итоговое число: {digit3}");