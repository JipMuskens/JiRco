using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public class DiskRequestScheduler
    {
        public DiskRequestScheduler(ISchedulingAlgorithm algorithm)
        {
            SetScheduler(algorithm);

            _requests = new List<int>();
            _processed_requests = new List<int>();

            _current_request_in_process = 0;
        }

        public void Start()
        {
            _processed_requests.Clear();
        }

        public void Stop()
        {

        }

        public void AddRequests(List<int> list)
        {
            if (list != null)
            {
                bool itemAlreadyAdded = false;
                foreach (var item in list)
                {
                    itemAlreadyAdded = false;
                    foreach (var item2 in _requests)
                    {
                        if (item == item2)
                        {
                            itemAlreadyAdded = true;
                            break;
                        }
                    }  

                    if (!itemAlreadyAdded)
                    { _requests.Add(item); }
                }
            }


            _requests.AddRange(list);
        }

        public void SetScheduler(ISchedulingAlgorithm algorithm)
        {
           if(algorithm == null)
           { throw new ArgumentNullException("algorithm is null"); }

            _algorithm = algorithm;
        }
        public List<int> GetProcessedRequests()
        {
            List<int> pr = _processed_requests;
            _processed_requests = new List<int>();

            return pr;
        }

        public int GetCurrentRequestInProgress()
        {
            return _current_request_in_process;
        }

        private ISchedulingAlgorithm _algorithm;
        private List<int> _requests;
        private List<int> _processed_requests;
        private int _current_request_in_process;
        private Timer _timer;
    }
}
