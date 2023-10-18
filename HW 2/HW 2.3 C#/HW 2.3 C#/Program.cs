using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = 1000;
        int k = 20;
        int[] intervals = new int[k];
        double[] rndVar = new double[n];

        for (int i = 0; i < n; i++)
        {
            rndVar[i] = rnd.NextDouble();
            Console.WriteLine($"\n rndVar[i] {rndVar[i]}");
        }

        foreach (var variate in rndVar)
        {
            int j = (int)(variate*k);
            intervals[j]++;
        }

        for (int i = 0; i < k; i++)
        {
            double first = (double)i / k;
            double last = (double)(i + 1) / k;
            Console.WriteLine($"\n i/k : {first:F1}, (i+1)/k : {last:F1} - {intervals[i]}");
        }
        Console.ReadLine();
    }
}