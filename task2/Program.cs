//Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int LenNumber (int number)
{
    int length = 0;
    while(number>0)
    {
        number= number/10;
        length ++;
    }
    return length;
}

int SumNumber(int number, int length)
{
    int result = 0;
    int i = 0;
    while(i<length)
    {
        result+=number%10;
        number=number/10;
        i++;
    }
    return result;

}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = LenNumber (number);
Console.WriteLine (len);
int res = SumNumber(number, len);
Console.WriteLine (res);

