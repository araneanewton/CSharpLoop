﻿public class Program
{

    private static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //
        int sum = 0;
        for (int i = 0; i < 20; i++)
        {
            if (myArray[i] % 2 != 0)
            {
                sum += myArray[i];
            }
        }
        Console.WriteLine(sum);
    }
}