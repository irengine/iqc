using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule41S : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule41S(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }

        public int GetValidCount()
        {
            int validCount = 0;

            for(int i = 3; i < rnds.Length; i++)
            {
                if (IsValid(rnds[i - 3], rnds[i - 2], rnds[i - 1], rnds[i]))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v1, double v2, double v3, double v4)
        {
            if (Math.Abs(v1 - mean) > variance &&
                Math.Abs(v2 - mean) > variance &&
                Math.Abs(v3 - mean) > variance &&
                Math.Abs(v4 - mean) > variance)
                return false;
            else
                return true;
        }
    }
}
