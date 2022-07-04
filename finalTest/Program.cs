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
string[] FindThreeSymbolElements(string[] threeSymbolElements)
{
    int count = 0;
    string arrayElement = String.Empty;
    for (int i = 0; i < threeSymbolElements.Length; i++)
    {
        arrayElement = threeSymbolElements[i];
        if (arrayElement.Length < 4)
        {
            count++;
        }
    }
    string[] result = new string[count];
    
    int calc = 0;
    for (int i = 0; i < threeSymbolElements.Length; i++)
    {
        arrayElement = threeSymbolElements[i];
        if (arrayElement.Length < 4)
        {
            result[calc] = arrayElement;
            calc++;
        }
    }
    return result;
}