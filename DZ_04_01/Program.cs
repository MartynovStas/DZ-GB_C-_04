/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
 натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16*/

int Namber(string A)
{
    System.Console.WriteLine(A);
    return Convert.ToInt32(Console.ReadLine());
}

int Stepen(int Hislo, int Hislo1)
{
    int stepen = 0;
    for (int i = 0; i <= Hislo1; i++)
    {
        stepen = Convert.ToInt32(Math.Pow(Hislo, Hislo1));
        i++;
    }
    return stepen;
}

int namber = Namber("Введите число А: ");
int namber1 = Namber("Введите число B: ");
Console.WriteLine($"Число {namber} в степени {namber1} = " + Stepen(namber, namber1));

