using System;
using System.Collections.Generic;
using System.Text;

namespace WeightedModelCounting.Models
{
    public class Problem
    {
        public string Descriptor { get; set; }
        public int NoVariables { get; set; }
        public int NoClauses { get; set; }

        //sample: p wcnf NumVariables NumClauses
        public Problem(string problemDescription)
        {
            Descriptor = string.Empty;
            NoVariables = 0;
            NoClauses = 0;

            string[] components = problemDescription.Split();
            if (components.Length == 4)
            {
                Descriptor = components[1];
                NoVariables = Convert.ToInt32(components[2]);
                NoClauses = Convert.ToInt32(components[3]);
            }
        }

        public override string ToString()
        {
            return $"p {Descriptor} {NoVariables} {NoClauses}";
        }
    }
}
