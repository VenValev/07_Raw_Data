using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Raw_Data
{
    public class Car
    {
        private string model;
        private Engine dvigatel;
        private Cargo bagaj;
        private Tyres guma1;
        private Tyres guma2;
        private Tyres guma3;
        private Tyres guma4;

        public Car(string model, Engine dvigatel, Cargo bagaj, Tyres guma1, Tyres guma2, Tyres guma3, Tyres guma4)
        {
            Model = model;
            Dvigatel = dvigatel;
            Bagaj = bagaj;
            Guma1 = guma1;
            Guma2 = guma2;
            Guma3 = guma3;
            Guma4 = guma4;

        }

        public string Model {get; set;}
        public Engine Dvigatel { get; set; }
        public Cargo Bagaj { get; set; }
        public Tyres Guma1 { get; set; }
        public Tyres Guma2 { get; set; }
        public Tyres Guma3 { get; set; }
        public Tyres Guma4 { get; set; }

    }
}
