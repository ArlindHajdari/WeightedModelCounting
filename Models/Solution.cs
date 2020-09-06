using System;
using System.Collections.Generic;
using System.Text;

namespace WeightedModelCounting.Models
{
    public class Solution
    {
        //e.g. wmc
        public string Descriptor { get; set; }
        //Number of solutions
        public double NoSolutions { get; set; }

        public override string ToString()
        {
            return $"s {Descriptor} {NoSolutions}";
        }
    }
}
