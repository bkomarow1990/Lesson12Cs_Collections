using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task3_HashMap
{
    class Auto : IEquatable<Auto>
    {
        public enum Type
        {
            Car = 1, Lorry, RaceCar, Bus, Bike,UND
        }
        private string name;
        public Type TypeAuto { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Incorrect car name");
                }
            }
        }
        public uint Year { get; set; }
        public Auto(Type type=Type.UND, string name="NoName", uint year=0)
        {
            TypeAuto = type;
            Name = name;
            Year = year;
        }
        public override string ToString()
        {
            return $"Auto Type: {TypeAuto}, Name: {Name}, Year: {Year}";
        }
        public override int GetHashCode()
        {
            return (TypeAuto.ToString() + Name.ToString() + Year.ToString()).GetHashCode();
        }

        public bool Equals(Auto other)
        {
            return this.name.Equals(other.name) && this.Year.Equals(other.Year) && this.TypeAuto.Equals(other.TypeAuto);
        }
    }
}
