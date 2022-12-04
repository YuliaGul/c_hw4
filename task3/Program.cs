//Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0; 
    while(index<length) 
    {
        Console.Write("Введите элемент массива = ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }

}
string PrintArray (int[]collection)
{
    int count = collection.Length;
    int position = 0;
    string result = "[ ";
    while(position < count)
    {
        result = result + ($"{collection[position]} ") + ($",") ;
        position++;
    }
    
    return result + "]";
}
int [] array = new int[8];
FillArray(array);
string newArray = PrintArray(array);
Console.WriteLine(newArray);

