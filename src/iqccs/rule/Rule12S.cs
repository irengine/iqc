using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule12S : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule12S(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }

        public int GetValidCount()
        {
            int validCount = 0;

            foreach (double rnd in rnds)
            {
                if (IsValid(rnd))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v)
        {
            if (Math.Abs(v - mean) > 2 * variance)
                return false;
            else
                return true;
        }
    }
}
