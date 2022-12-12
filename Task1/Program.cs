/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
Например: 3, 5 -> 243 (3⁵) 2, 4 -> 16*/

Console.WriteLine("Enter number A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number B:");
int B = int.Parse(Console.ReadLine());
int num = 1;

for (int i = 1; i <= B; i++)
{
    num = num * A;
}

Console.WriteLine(num);
