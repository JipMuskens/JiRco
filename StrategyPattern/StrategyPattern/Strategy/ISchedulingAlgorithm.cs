using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface ISchedulingAlgorithm
    {
        // Returns the index of the element that will be processed
        // Should return -1 if no item should be processed
        int FindNextItemToProcess(List<int> list, int current_request);
    }
}
