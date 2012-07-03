using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule2of32S : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule2of32S(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }

        public int GetValidCount()
        {
            int validCount = 0;

            for(int i = 2; i < rnds.Length; i++)
            {
                if (IsValid(rnds[i - 2], rnds[i - 1], rnds[i]))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v1, double v2, double v3)
        {
            if ((Math.Abs(v3 - mean) > 2 * variance) &&
                ((Math.Abs(v2 - mean) > 2 * variance) ||
                (Math.Abs(v1 - mean) > 2 * variance)))
                return false;
            else
                return true;
        }
    }
}
