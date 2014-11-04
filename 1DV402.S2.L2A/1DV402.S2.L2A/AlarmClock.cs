using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2A
{
    class AlarmClock
    {
        //variables
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        static private int _minute;

        //Properties
        public int AlarmHour
        {
            get
            {
                return _alarmHour;
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    _alarmHour = value;
                }
                else
                {
                    throw new ArgumentException("AlarmTimmen är inte i intervallet 0-23.");
                }
            }
        }
        public int AlarmMinute
        {
            get
            {
                return _alarmMinute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _alarmMinute = value;
                }
                else
                {
                    throw new ArgumentException("AlarmMinuten är inte i intervallet 0-59.");
                }
            }
        }
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                }
            }
        }
        public int Minute
        {
            get
            { return _minute; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }
            }
        }

        // constructors
        public AlarmClock()
            : this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //Methods
        public bool TickTock()
        {
            //kanske!?
            _minute++;
            if (_minute > 59)
            {
                _minute = 0;
                _hour++;
                if (_hour > 23)
                {
                    _hour = 0;
                }
            }

            if (_minute == _alarmMinute && _hour == _alarmHour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {

            string minuteParsed = Convert.ToString(_minute);
            string hourParsed = Convert.ToString(_hour);
            string formated = null;

            // vanlig tid
            Console.Write("     ");
            if (_hour < 10)
            {
                formated += "0" + hourParsed + ":";
            }
            else
            {
                formated += hourParsed + ":";
            }

            if (_minute < 10)
            {
                formated += "0" + minuteParsed;
            }
            else
            {
                formated += minuteParsed;
            }

            // alarmtid
            minuteParsed = Convert.ToString(_alarmMinute);
            hourParsed = Convert.ToString(_alarmHour);
            formated += " <";
            if (_alarmHour < 10)
            {
                formated += "0" + hourParsed + ":";
            }
            else
            {
                formated += hourParsed + ":";
            }

            if (_alarmMinute < 10)
            {
                formated += "0" + minuteParsed;
            }
            else
            {
                formated += minuteParsed;
            }

            formated += ">";

            return formated;
        }

    }
}
