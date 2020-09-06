using System;
using WeightedModelCounting.Extensions;
using WeightedModelCounting.Models;

namespace WeightedModelCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Instance instance = IO.ReadCNF("Inputs/track2_000.wcnf");
            Console.WriteLine(instance.ToString());
            Console.ReadKey();
        }
    }
}
