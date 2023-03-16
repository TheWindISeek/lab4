using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            hour = System.DateTime.Now.Hour;
            minute = System.DateTime.Now.Minute;
            second = System.DateTime.Now.Second;
        }

        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }
        public int Second { get { return second; } }

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public bool AddSecond(int _second)
        {
            this.second += _second;
            if (second >= 60)
            {
                minute += second / 60;
                second %= 60;
                if (minute >= 60) 
                { 
                    this.hour += minute / 60;
                    minute %= 60;
                }
            }
            return true;
        }
    }
}
