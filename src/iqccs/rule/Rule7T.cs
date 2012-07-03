using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iqccs.rule
{
    class Rule7T : IRule
    {
        private double mean;
        private double variance;
        private double[] rnds;

        public Rule7T(double mean, double variance, double[] rnds)
        {
            this.mean = mean;
            this.variance = variance;
            this.rnds = rnds;
        }
        
        public int GetValidCount()
        {
            int validCount = 0;

            for (int i = 6; i < rnds.Length; i++)
            {
                if (IsValid(rnds[i - 6], rnds[i - 5], rnds[i - 4], rnds[i - 3], rnds[i - 2], rnds[i - 1], rnds[i]))
                    validCount++;
            }

            return validCount;
        }

        public bool IsValid(double v1, double v2, double v3, double v4, double v5, double v6, double v7)
        {
            if ((v1 - v2 > 0.0 &&
                v2 - v3 > 0.0 &&
                v3 - v4 > 0.0 &&
                v4 - v5 > 0.0 &&
                v5 - v6 > 0.0 &&
                v6 - v7 > 0.0) ||
                (v1 - v2 < 0.0 &&
                v2 - v3 < 0.0 &&
                v3 - v4 < 0.0 &&
                v4 - v5 < 0.0 &&
                v5 - v6 < 0.0 &&
                v6 - v7 < 0.0))
                return false;
            else
                return true;
        }
    }
}
