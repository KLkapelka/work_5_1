// Дан файл numsTask1.txt с целыми числами, вычислите произведение элементов расположенных после минимального;

using System;
using System.IO;

class work_5_1
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask1.txt"); 
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); 
        int min = chosenUse[0]; 
        int numbers = 1; 
        
        for (int i = 0; i < chosenUse.Length; i++)
        {
            if (chosenUse[i] < min) 
            {
                min = i; 
            }
        }

        for (int i = min + 1; i < chosenUse.Length; i++) 
        {
            numbers *= chosenUse[i]; 
        }
        Console.WriteLine($"Произведение элементов после минимального числа: {numbers}"); 
    }
}
