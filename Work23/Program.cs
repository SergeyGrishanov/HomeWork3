// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;

while (num >= count)
{
    Console.Write($"{Math.Pow(count,3)}");
    if (count != num) Console.Write(", ");
    count++;
}
