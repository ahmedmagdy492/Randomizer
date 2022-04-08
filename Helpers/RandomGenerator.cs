using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer.Helpers
{
    public static class RandomGenerator
    {
        public static int Generate(int strsCount)
        {
            return new Random().Next(0, strsCount);
        }
    }
}
