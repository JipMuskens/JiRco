using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SCANSchedulingAlgorithm : ISchedulingAlgorithm
    {
        bool reading_backwards;

        public int FindNextItemToProcess(List<int> list, int current_request)
        {
            int index_to_process = -1;

            if (list != null && list.Count > 0)
            {
                int smallest_found_difference = int.MaxValue;

                if (reading_backwards)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        int value = list.ElementAt(i);

                        if (value < current_request)
                        {
                            int calculated_difference = current_request - value;

                            if (calculated_difference < smallest_found_difference)
                            {
                                smallest_found_difference = calculated_difference;
                                index_to_process = i;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        int value = list.ElementAt(i);

                        if (value > current_request)
                        {
                            int calculated_difference = value - current_request;

                            if (calculated_difference < smallest_found_difference)
                            {
                                smallest_found_difference = calculated_difference;
                                index_to_process = i;
                            }
                        }
                    }
                }

                // Couldn't find an item in current direction
                if (index_to_process == -1)
                {
                    // reverse direction and try again
                    reading_backwards = !reading_backwards;
                    index_to_process = FindNextItemToProcess(list, current_request);
                }
            }

            return index_to_process;
        }
    }
}
