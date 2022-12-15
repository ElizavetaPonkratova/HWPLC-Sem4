/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]*/

Console.Write("Enter the number of array elements:");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Enter the array elements {i}:");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Array output:");
Console.Write("[");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + ",");
}
Console.Write("]");