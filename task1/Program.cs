//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int DegreeFunction (int number, int degree)
{
    int i = 0;
    int result = 1; 
    while (i < degree)
    {
        result *= number;
        i++;
    }
    return result;
}
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int res = DegreeFunction (number1, number2);
Console.WriteLine (res);
