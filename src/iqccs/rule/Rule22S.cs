using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule22S : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule22S(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }

        public int GetValidCount()
        {
            int validCount = 0;

            for(int i = 1; i < rnds.Length; i++)
            {
                if (IsValid(rnds[i - 1], rnds[i]))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v1, double v2)
        {
            if ((Math.Abs(v1 - mean) > 2 * variance) &&
                (Math.Abs(v2 - mean) > 2 * variance))
                return false;
            else
                return true;
        }
    }
}
