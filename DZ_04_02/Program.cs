/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int Chislo(string namber)
{
    System.Console.WriteLine(namber);
    return Convert.ToInt32(Console.ReadLine());
}
int Index(int n)
{
    int index = 0;
    while (n > 0)
    {
        n = n / 10;
        index++;
    }
    return index;
}
int Summ(int n, int inde)
{
    int summ = 0;
    for (int i = 1; i <= inde; i++)
    {
        summ = summ + n % 10;
        n = n / 10;
    }
    return summ;
}
int namber = Chislo("Введите число");
int index = Index(namber);
int summ = Summ(namber, index);
System.Console.WriteLine($"Сумма чисел равна: {summ}");