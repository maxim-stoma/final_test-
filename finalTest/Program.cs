void SetArray(string[] stringArray)
{
    Console.WriteLine("Напечатай выдуманные слова: ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{i + 1}-е слово в твоём словаре: "); ;
        stringArray[i] = Console.ReadLine()!;
    }

}
