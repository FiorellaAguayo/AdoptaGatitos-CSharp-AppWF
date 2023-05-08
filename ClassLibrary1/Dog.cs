using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dog : Animal
    {
        private bool _castrated;

        public Dog(int id, string type, string name, string color, bool race, int age, string gender, string size, bool adopted, bool castrated) : base(id, type, name, color, race, age, gender, size, adopted)
        { 
           _castrated = castrated;
        }

        public bool Castrated { get { return _castrated; } set { _castrated = value; } }
    }
}