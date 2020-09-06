using System;
using System.Collections.Generic;
using System.Text;

namespace WeightedModelCounting.Models
{
    public class Weight
    {
        public int Literal { get; set; }
        public double Number { get; set; }

        //sample: w Literal Weight 0
        public Weight(string weightFunction)
        {
            Literal = -1;
            Number = -1;

            string[] components = weightFunction.Split();
            if (components.Length == 4 || components.Length == 3)
            {
                Literal = Convert.ToInt32(components[1]);
                Number = Convert.ToDouble(components[2]);
            }
        }

        public override string ToString()
        {
            return $"w {Literal} {Number} 0";
        }
    }
}
