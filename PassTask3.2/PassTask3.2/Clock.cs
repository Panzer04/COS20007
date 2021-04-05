using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTask3._2
{
    public class Clock
    {
        Counter _seconds = new Counter("seconds");
        Counter _minutes = new Counter("minutes");
        Counter _hours = new Counter("hours");
        public Clock()
        {

        }
        public void Tick()
        {
            _seconds.Increment();
            if(_seconds.Ticks > 59)
            {
                _minutes.Increment();
                _seconds.Reset();
                if (_minutes.Ticks > 59)
                {
                    _hours.Increment();
                    _minutes.Reset();
                    if(_hours.Ticks > 23)
                    {
                        Reset();
                    }
                }
            }
        }
        
        public void Reset()
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        //Returns a string formatted as HH:MM:SS with filler zeros
        public string Time()
        {
            return _hours.Ticks.ToString("D2") + ":" + _minutes.Ticks.ToString("D2") + ":" + _seconds.Ticks.ToString("D2");
        }

    }
}
