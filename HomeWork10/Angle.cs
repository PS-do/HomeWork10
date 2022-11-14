using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else if (value > 359) this.gradus = value % 360;
                else this.gradus = value;
            }
        }
        public int Minute
        {
            get { return min; }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    Gradus += value / 360;
                    min = value % 60;
                }
            }
        }

        public int Second
        {
            get { return sec; }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    Minute += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Angle(int hour, int minute, int second)
        {
            this.Gradus = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public double ToRadian()
        {
            return (sec/60/60 + min/60 + gradus) / 180*Math.PI;
        }
    }
}
