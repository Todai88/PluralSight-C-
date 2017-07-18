using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(0, 10)
                            .Select(i => 5 + (10 * i));
                        
            return integers;
        }

        public IEnumerable<string> BuildStringSequence()
        {
            var strings = Enumerable.Range(0, 10)
                                     .Select(i => ((char)('A' + i)).ToString());

            return strings;
        }

        public IEnumerable<int> CompareSequence()
        {
            var sequenceOne = Enumerable.Range(0, 10);
            var sequenceTwo = Enumerable.Range(0, 10)
                                    .Select(i => i * i);

            return Enumerable.Union(sequenceOne, sequenceTwo);
        }
    }
}
