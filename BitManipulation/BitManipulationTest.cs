﻿namespace BitManipulation;

public static class BitManipulationTest
{
    public static void Main()
    {
        var arr = new int[5];
        
        arr[0] = 1; 
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(~i);
        }
    }
}