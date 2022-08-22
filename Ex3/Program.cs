// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45-->101101
//3-->11
//2-->10

void MakeBinary()
{
    Console.Write("Введите натуральное число");
    int number = Convert.ToInt32(Console.ReadLine());

    string binary = string.Empty;
    int n = number;
    while(n > 0)
    {
        binary = $"{n % 2}" + binary;
        n /= 2;
    }
    Console.WriteLine ($"{number} --> {binary}");
}
MakeBinary();