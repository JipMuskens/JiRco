using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //shortest seek time first
    class SSTFSchedulingAlgorithm : ISchedulingAlgorithm
    {
        public int FindNextItemToProcess(List<int> list, int current_request)
        {
            int index_to_process = -1;
            int smallest_found_difference = int.MaxValue;

            if (list != null)
            for(int i = 0; i < list.Count; i++)
            {
                int value = list.ElementAt(i);
                int calculated_difference = Math.Abs(value - current_request);

                if(calculated_difference < smallest_found_difference)
                {
                    smallest_found_difference = calculated_difference;
                    index_to_process = i;
                }
            }

            return index_to_process;
        }
    }
}