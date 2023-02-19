//Задача №14. Работа в группах
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int digit1 = number1%7;
int digit2 = number1%23;
if (digit1  == 0 && digit2  == 0) 
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}