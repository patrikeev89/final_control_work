using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        string[] resultArray = FilterStrings(inputArray);
        Console.WriteLine("Новый массив: " + string.Join(" ", resultArray));
        Console.ReadLine();
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}