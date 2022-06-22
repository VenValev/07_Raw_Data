using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Raw_Data
{
    public class Tyres
    {
        private int age;
        private double preassure;

        public Tyres(int age, double preassure)
        {
            Age = age;
            Preassure = preassure;
        }
        public int Age { get; set; }
        public double Preassure { get; set; }
    }
}
