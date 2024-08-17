using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Timer = System.Threading.Timer;

namespace Abdal_Security_Group_App.Core
{
    public class GlobalpUpdaterTimer
    {
        private static GlobalpUpdaterTimer _instance;
        private Timer _timer;
        private bool _isRunning;
        private int _interval; // Interval in milliseconds
        private Action _action; // The action to perform

        // Private constructor to prevent direct instantiation
        private GlobalpUpdaterTimer()
        {
        }

        // Public static method to get the single instance
        public static GlobalpUpdaterTimer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalpUpdaterTimer();
                }

                return _instance;
            }
        }

        // Initialize the timer with interval and action
        public void Initialize(int interval, Action action)
        {
            _interval = interval;
            _action = action;
        }

        // Start the timer
        public void Start()
        {
            if (_isRunning || _action == null)
                return;

            _timer = new Timer(OnTimerElapsed, null, 0, _interval);
            _isRunning = true;
        }

        // Stop the timer
        public void Stop()
        {
            if (!_isRunning)
                return;

            _timer.Change(Timeout.Infinite, Timeout.Infinite);
            _timer.Dispose();
            _isRunning = false;
        }

        // Update the timer interval
        public void UpdateInterval(int newInterval)
        {
            _interval = newInterval;
            if (_isRunning)
            {
                _timer.Change(0, _interval);
            }
        }

        public bool IsRunning => _isRunning;

        private void OnTimerElapsed(object state)
        {
            try
            {
                _action.Invoke();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                // Console.WriteLine("Error in timer execution: " + ex.Message);
            }
        }
    }
}