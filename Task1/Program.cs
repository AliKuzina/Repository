internal class Program
{
    private static void Main(string[] args)
    {
        int arraySize;
        Console.Write("Введите размер массива строк: ");
        while (!int.TryParse(Console.ReadLine(), out arraySize))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }

        string[] inputArray = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        int shortStringsCount = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                shortStringsCount++;
            }
        }

        string[] shortStrings = new string[shortStringsCount];
        int j = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                shortStrings[j] = str;
                j++;
            }
        }
    }
}