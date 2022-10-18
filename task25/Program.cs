// Задача 25: 
// 1.Напишите цикл, который принимает на вход два числа (A и B).
// 2.Возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numbaA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbaB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int A, int B)
{
    int number = A;
    for (int i = 1; i < B; i++)
    {
        number = number * A;
    }
    return number;
}

if(numbaA<1 || numbaB<1)
    {
        Console.WriteLine("Ошибка!");
        Console.WriteLine(" Нужно везти целое чисо");
    }
else
{
int exponentiation = Exponentiation(numbaA,numbaB);
Console.WriteLine($" {numbaA} возвести в степень {numbaB} = {exponentiation}");
}