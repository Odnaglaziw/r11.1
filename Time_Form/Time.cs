using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Form
{
    internal class Time
    {
        public Time()
        {
            second = 0;
            minute = 0;
            hour = 0;
        }
        public Time(int Seconds, int Minutes, int Hours)
        {
            second = Seconds;
            minute = Minutes;
            hour = Hours;
        }
        private int second;
        private int minute;
        private int hour;
        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                second = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                minute = value;
            }
        }
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                hour = value;
            }
        }
        private void Check()
        {
            if (second >= 60)
            {
                minute += second / 60;
                second = second % 60;
            }
            if (minute >= 60)
            {
                hour += minute / 60;
                minute = minute % 60;
            }
            if (hour >= 24)
            {
                hour += hour / 24;
                hour = hour % 24-1;
            }
            if (second < 0)
            {
                minute--;
                second+=60;
            }
            if (minute < 0 && hour > 0)
            {
                hour--;
                minute += 60;
            }
            //else if (second < 0 && hour == 0 && minute == 0)
            //{
            //    second = 0;
            //}
        }
        public void AddSecond(int Seconds)
        {
            second += Seconds;
            Check();
        }
        public void AddMinute(int Minutes)
        {
            minute += Minutes;
            Check();
        }
        public void AddHour(int Hours)
        {
            hour += Hours;
            Check();
        }
        public override string ToString()
        {
            return $"{hour.ToString().PadLeft(2,'0')}:{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }
    }
}
