using System;
using Operazioni;
namespace OrdinamentoStipendi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci dimensione array: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[x];
            Console.WriteLine("Inserisci stipendi: ");
            Gestione.LeggiArray(array);
            Gestione.BubbleSort(array, x);
            Console.WriteLine($"Gli stipendi ordinati sono: ");
            Gestione.StampaArray(array);
            double max = Gestione.MaxTraElementi(array);
            double min = Gestione.MinTraElementi(array);
            Console.WriteLine($"Il max degli stipendi è: {max}, il min è {min}.");
        }
    }
}
