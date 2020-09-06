using System;
using System.Collections.Generic;
using System.Text;
using WeightedModelCounting.Enumerators;
using WeightedModelCounting.Models;

namespace WeightedModelCounting.Extensions
{
    public static class String
    {
        public static LineType ToLineType(this string item)
        {
            if (item.StartsWith("p "))
            {
                return LineType.PROBLEM_DESCRIPTION;
            }
            else if (item.StartsWith("w "))
            {
                return LineType.WEIGHT_FUNCTION;
            }
            else if (char.IsNumber(item[0]) || (item[0] == '-' && char.IsNumber(item[1])))
            {
                return LineType.CLAUSE;
            }

            return LineType.NOT_DEFINED;
        }

        public static string Describe(this List<Weight> weights)
        {
            string result = string.Empty;
            weights.ForEach(x => {
                result += x.ToString();
                result += System.Environment.NewLine;
            });
            return result;
        }

        public static string Describe(this List<Clause> clauses)
        {
            string result = string.Empty;
            clauses.ForEach(x => {
                result += x.ToString();
                result += System.Environment.NewLine;
            });
            return result;
        }
    }
}
