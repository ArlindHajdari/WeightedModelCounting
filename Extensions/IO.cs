using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WeightedModelCounting.Enumerators;
using WeightedModelCounting.Models;

namespace WeightedModelCounting.Extensions
{
    public static class IO
    {
        public static Instance ReadCNF(string CNFpath)
        {
            Instance result = new Instance();
            List<string> lines = File.ReadAllLines(CNFpath).ToList();
            lines.RemoveAll(x => x.StartsWith("c ")); //Remove unnecesary lines (comments)

            if (IsCNFValid(lines))
            {
                foreach (string line in lines)
                {
                    switch (line.ToLineType())
                    {
                        case LineType.PROBLEM_DESCRIPTION:
                            result.Problem = new Problem(line);
                            break;
                        case LineType.WEIGHT_FUNCTION:
                            {
                                if (result.Weights.Count < result.Problem.NoVariables)
                                {
                                    result.Weights.Add(new Weight(line)); 
                                }
                                break;
                            }
                        case LineType.CLAUSE:
                            {
                                if (result.Clauses.Count < result.Problem.NoClauses)
                                {
                                    result.Clauses.Add(new Clause(line)); 
                                }
                                break;
                            }
                        default:
                            break;
                    }
                } 
            }

            return result;
        }

        public static bool IsCNFValid(List<string> CNFFileLines)
        {
            bool isValid = true;
            if (CNFFileLines.Count(x => x.StartsWith("p ")) > 1)
            {
                isValid = false;
            }
            else if (CNFFileLines.FindIndex(x => x.StartsWith("p ")) > 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
