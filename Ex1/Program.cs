// Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте,а первый на последнем)
//[1 2 3 4 5]---> [5 4 3 2 1]

int [] CreateArray(int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void ReversArray(int[]arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        //arr[1]<-->arr[arr.Length -1-i]
        int temp = arr[i];
        arr[i] = arr[arr.Length -1-i];
        arr[arr.Length -1-i] = temp;
    }
}

int [] array = CreateArray(10, -5, 10);
PrintArray(array);
Console.WriteLine();
ReversArray(array);
PrintArray(array);
