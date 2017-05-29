using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //First In First Out
    class FIFOSchedulingAlgorithm : ISchedulingAlgorithm
    {
        public int FindNextItemToProcess(List<int> list, int current_request)
        {
            int index_to_process = -1;
            if(list != null && list.Count > 0)
            { index_to_process = 0; }

            return index_to_process;
        }
    }
}
