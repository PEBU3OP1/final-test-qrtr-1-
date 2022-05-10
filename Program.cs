string[] NewArrayFilling()
{
    Console.WriteLine("Какое число членов массива: ");
    int ArrayLen = Convert.ToInt32(Console.ReadLine());
    string[] ar = new string[ArrayLen];

    for (int i = 0; i < ar.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} член массива: ");
        ar[i] = Console.ReadLine();
        while (ar[i] == "")
        {
            Console.WriteLine("Вы ничего не ввели!!!");
            Console.WriteLine($"Введите {i + 1} член массива: ");
            ar[i] = Console.ReadLine();
        }


    }
    Console.WriteLine();
    Console.WriteLine("Вот Ваш исходный массив: ");
    foreach (string s in ar) Console.Write(s + " ");

    return ar;
}
int ArrayCount(string[] ar)
{
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}
void FinalArray(string[] ar, int count)
{
    string[] finalArray = new string[count];
    int i = 0;

    Console.WriteLine("Финальный массив: ");
    for (int j = 0; j < ar.Length; j++)
    {
        if (ar[j].Length < 4)
        {
            finalArray[i] = ar[j];
            Console.Write(finalArray[i] + " ");
            i++;
        }

    }


}

string[] Arr = NewArrayFilling();
Console.WriteLine();
FinalArray(Arr, ArrayCount(Arr));
