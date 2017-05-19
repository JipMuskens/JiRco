using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StrategyPattern
{
    /*
        The diskRequestScheduler is responsible for completing requests.
        Makes use of an scheduling algorithm in order determine what request to complete.

        This is a simulation class; simulates the processing of requests that are represented by ids (ints).
    */
    public class DiskRequestScheduler
    {
        public DiskRequestScheduler(ISchedulingAlgorithm algorithm)
        {
            SetScheduler(algorithm);

            _requests = new List<int>();
            _processed_requests = new List<int>();

            _current_request_in_process = -1;

            _timer = new Timer();
            _timer.Elapsed += (sender, e) => OnTimedEvent(sender, e, this);
            _timer.Interval = 1000;

        }

        public void Start()
        {
            _processed_requests.Clear();
            _timer.Enabled = true;
        }

        public void Stop()
        {
            _timer.Enabled = false;
        }

        public void AddRequest(int item)
        {
            bool itemAlreadyAdded = false;

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

        public void AddRequests(List<int> list)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    AddRequest(item); 
                }
            }
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

        private static void OnTimedEvent(object source, ElapsedEventArgs e, DiskRequestScheduler obj)
        {
            obj.tick();
        }

        private void tick()
        {
            // use currentreqeust in progress var to get the value in requests, and remove it
            // then add it to processed requests
            if (_current_request_in_process != -1)
            {
                _requests.Remove(_current_request_in_process);
                _processed_requests.Add(_current_request_in_process);
            }


            int index_to_process = _algorithm.FindNextItemToProcess(_requests, _current_request_in_process);

            if (index_to_process != -1)
            {
                _current_request_in_process = _requests.ElementAt(index_to_process);
            }
            else
            {
                _current_request_in_process = -1;
                Stop();
            }
        }

        private ISchedulingAlgorithm _algorithm;
        private List<int> _requests;
        private List<int> _processed_requests;
        private int _current_request_in_process;
        private Timer _timer;

        public bool IsWorking
        { get { return _timer.Enabled; } }

        public int RequestInProcess
        { get { return _current_request_in_process; } }
    }
}
