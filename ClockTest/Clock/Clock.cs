using System;
using System.Collections.Generic;

namespace Clock
{
    public class Clock
    {
        private Counter _hour, _minute, _second;

        public Clock()
        {
             _hour = new Counter("hour");
             _minute = new Counter("second");
             _second = new Counter("minute");
        }

        public void Tick()
        {
            _second.Increment();

            if (_second.Ticks > 59)
            {
                _second.Reset();
                _minute.Increment();

                if (_minute.Ticks > 59)
                {
                    _minute.Reset();
                    _hour.Increment();
                }
            }

            if (_hour.Ticks > 23)
            {
                _hour.Reset();
            }
        }

        public void Reset()
        {
            _hour.Reset();
            _minute.Reset();
            _second.Reset();
        }

        public string GetTime()
        {
            return $"{_hour.Ticks:D2}:{_minute.Ticks:D2}:{_second.Ticks:D2}";
        }
    }
}
