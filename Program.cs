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