using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Raw_Data
{
    public class Cargo
    {
        private string vid;
        private int weight;

        public Cargo(string vid, int weight)
        {
            Vid = vid;
            Weight = weight;
        }
        public string Vid { get; set; }
        private int Weight { get; set; }
    }
}
