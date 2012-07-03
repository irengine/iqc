using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule9X : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule9X(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }
        
        public int GetValidCount()
        {
            int validCount = 0;

            for (int i = 8; i < rnds.Length; i++)
            {
                if (IsValid(rnds[i - 8], rnds[i - 7], rnds[i - 6], rnds[i - 5], rnds[i - 4], rnds[i - 3], rnds[i - 2], rnds[i - 1], rnds[i]))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v1, double v2, double v3, double v4, double v5, double v6, double v7, double v8, double v9)
        {
            if (Math.Abs(v1 - mean) > 0.0 &&
                Math.Abs(v2 - mean) > 0.0 &&
                Math.Abs(v3 - mean) > 0.0 &&
                Math.Abs(v4 - mean) > 0.0 &&
                Math.Abs(v5 - mean) > 0.0 &&
                Math.Abs(v6 - mean) > 0.0 &&
                Math.Abs(v7 - mean) > 0.0 &&
                Math.Abs(v8 - mean) > 0.0 &&
                Math.Abs(v9 - mean) > 0.0)
                return false;
            else
                return true;
        }
    }
}
