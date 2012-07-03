using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    public class RuleManager
    {
        public static double GetValid(string ruleName, double mean, double variance, double[] rnds)
        {
            int totalCount = rnds.Length;
            int validCount = 0;

            IRule rule = GetRule(ruleName, mean, variance, rnds);
            validCount = rule.GetValidCount();

            return 100.0 * validCount / totalCount;
        }

        public static IRule GetRule(string ruleName, double mean, double variance, double[] rnds)
        {
            switch (ruleName)
            {
                case "13S":
                    return new Rule13S(mean, variance, rnds);
                case "12S":
                    return new Rule12S(mean, variance, rnds);
                case "22S":
                    return new Rule22S(mean, variance, rnds);
                case "R4S":
                    return new RuleR4S(mean, variance, rnds);
                case "41S":
                    return new Rule41S(mean, variance, rnds);
                case "10X":
                    return new Rule10X(mean, variance, rnds);
                case "8X":
                    return new Rule8X(mean, variance, rnds);
                case "12X":
                    return new Rule12X(mean, variance, rnds);
                case "2of32S":
                    return new Rule2of32S(mean, variance, rnds);
                case "31S":
                    return new Rule31S(mean, variance, rnds);
                case "6X":
                    return new Rule6X(mean, variance, rnds);
                case "9X":
                    return new Rule6X(mean, variance, rnds);
                case "7T":
                    return new Rule6X(mean, variance, rnds);
                default:
                    throw new Exception("Rule is not defined.");
            }
        }
    }
}
