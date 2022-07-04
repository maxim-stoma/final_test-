void SetArray(string[] stringArray)
{
    Console.WriteLine("Напечатай выдуманные слова: ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{i + 1}-е слово в твоём словаре: "); ;
        stringArray[i] = Console.ReadLine()!;
    }

}
void PrintArray(string[] stringArrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < stringArrayToPrint.Length; i++)
    {
        Console.Write(stringArrayToPrint[i]);
        if (i != stringArrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}