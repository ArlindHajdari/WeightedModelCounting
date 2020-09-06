using System;
using System.Collections.Generic;

namespace WeightedModelCounting.Models
{
    public class Clause
    {
        public List<int> Items { get; set; }

        public Clause(string clause)
        {
            Items = new List<int>();

            string[] components = clause.Split();
            if (components.Length > 0)
            {
                foreach (string item in components)
                {
                    Items.Add(Convert.ToInt32(item));
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" ", Items);
        }
    }
}