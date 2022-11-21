/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

var num = Input("Введите пятизначное число: ");
Palindrom (num);

string Input(string msg)
{
    Console.Write(msg);
    return Console.ReadLine()??"";
}

static void Palindrom(string num)
{
    if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}