using System;

class Program
{
    static void Main()
    {
        int[] nums = { 5, 2, 9, 1, 5, 6 };
        int minValue = Min(nums);
        Console.WriteLine("Min: " + minValue);
    }

    static int Min(int[] arr)
    {
        int minValue = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }

        return minValue;
    }
}
