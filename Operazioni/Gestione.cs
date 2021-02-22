using System;

namespace Operazioni
{
    public class Gestione
    {
        public static void BubbleSort(double[] n, int tanti)
        {
            int x, y;
            double temp;
            for (x = 0; x < tanti - 1; x++)
            {
                for (y = 0; y < tanti - 1 - x; y++)
                {
                    if (n[y] > n[y + 1])
                    {
                        temp = n[y];
                        n[y] = n[y + 1];
                        n[y + 1] = temp;
                    }
                }
            }
        }
        public static void LeggiArray(double[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}°: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public static void StampaArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static double MaxTraElementi(double[] array)
        {
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static double MinTraElementi(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
    }
}
