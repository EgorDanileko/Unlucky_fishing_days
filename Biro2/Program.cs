using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int N = System.Convert.ToInt32(System.Console.ReadLine());
        int[] amountFish = new int[N];
        int[] indexTrue = new int[N];
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            amountFish[i] = System.Convert.ToInt32(System.Console.ReadLine());

            if (amountFish[i] < 5)
            {
                count++;
                indexTrue[i] = i+1;
            }
            else
            {
                indexTrue[i] = 0;
            }
        }
        Console.Write(count);
        for (int i = 0; i < N; i++)
        {
            if (indexTrue[i] != 0)
                Console.Write($" {indexTrue[i]}");
        }

    }
}