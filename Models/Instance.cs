using System;
using System.Collections.Generic;
using System.Text;
using WeightedModelCounting.Extensions;

namespace WeightedModelCounting.Models
{
    public class Instance
    {
        public Problem Problem { get; set; }
        public List<Weight> Weights { get; set; }
        public List<Clause> Clauses { get; set; }
        public Instance()
        {
            Weights = new List<Weight>();
            Clauses = new List<Clause>();
        }
        public override string ToString()
        {
            string result = string.Empty;

            result += Problem.ToString();
            result += System.Environment.NewLine;
            result += Weights.Describe();
            result += Clauses.Describe();

            return result;
        }
    }
}
