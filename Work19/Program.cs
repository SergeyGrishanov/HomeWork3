// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 0;
int num1 = num;
while (num1 > 0)
{
    result *=10;
    result += num1 % 10;
    num1 /= 10;
}
if (num == result)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}