using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cat : Animal
    {
        private bool _isFurry;
        public Cat(int id, string type, string name, string color, bool race, int age, string gender, string size, bool adopted, bool isFurry) : base (id, type, name, color, race, age, gender, size, adopted)
        {
            _isFurry = isFurry;
        }

        public bool IsFurry { get {  return _isFurry; } set { _isFurry = value; } }
    }
}