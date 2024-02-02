using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Form
{
    public class Student
    {
        public string Name { get; set; }
        public int Rost { get; set; }
        public double Ves { get; private set; }

        public void SetEat(double eda)
        {
            if (eda > 5 && eda <= 10)
            {
                Rost -= 1;
                Ves += 0.7 * (eda * 1000 - 1600);
            }
            else if (eda > 10)
            {
                Rost -= 2;
                Ves += 0.5 * (eda * 1000 - 1800);
            }
            else
            {
                Ves += eda * 1000;
            }
        }
    }
}
