using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 4, 5, 6, 7, 8, 9, 1, 2, 15 };
        int[] arr2 = { 11, 7, 9, 8, 6, 3, 1, 2, 4, 23 };

        FindAllDistances(arr, arr2);
    }

    static void FindAllDistances(int[] arr1, int[] arr2)
    {
        int minDistance = int.MaxValue;
        int num1 = 0, num2 = 0;

        foreach (int a in arr1)
        {
            foreach (int b in arr2)
            {
                int distance = Math.Abs(a - b);
                Console.WriteLine($"Distância entre {a} e {b} é {distance}");
                if (distance < minDistance)
                {
                    minDistance = distance;
                    num1 = a;
                    num2 = b;
                }
            }
        }

        Console.WriteLine($"\nA menor distância é {minDistance} entre os números {num1} e {num2}");
    }
}
