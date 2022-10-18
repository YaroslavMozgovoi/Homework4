// Задача 27: 
// 1.Напишите программу, которая принимает на вход число.
// 2.Выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int n)
{
    int sum = 0;
    while (n>0)
    {
        sum = sum + n%10;
        n = n/10; 
    }
    return sum;
}

int sumS = Sum(number);
Console.WriteLine(sumS);