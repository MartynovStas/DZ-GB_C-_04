/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int Namber(string n)
{
    System.Console.WriteLine(n);
    return Convert.ToInt32(Console.ReadLine());
}
int namber = Namber("Задайте число массива: ");
int[] arrey = new int[namber];
for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(1, 9);
}
System.Console.Write("[" + string.Join(" ,", arrey) + "]");