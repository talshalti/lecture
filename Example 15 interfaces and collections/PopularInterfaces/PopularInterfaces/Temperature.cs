using System;

namespace PopularInterfaces
{
    public class Temperature : IComparable
    {
        // The temperature value 
        protected double temperatureF;


        public double Fahrenheit
        {
            get
            {
                return this.temperatureF;
            }
            set
            {
                this.temperatureF = value;
            }
        }

        public double Celsius
        {
            get
            {
                return (this.temperatureF - 32) * (5.0 / 9);
            }
            set
            {
                this.temperatureF = (value * 9.0 / 5) + 32;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Temperature otherTemperature = obj as Temperature;
            if (otherTemperature != null)
                return this.temperatureF.CompareTo(otherTemperature.temperatureF);
            else
                throw new ArgumentException("Object is not a Temperature");
        }
    }

}
