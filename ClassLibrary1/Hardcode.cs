using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hardcode
    {
        public static void ListAnimals(List<string> list)
        {
            List<Animal> listAnimals = new List<Animal>
            {
                new Cat(1, "gato", "Mudi", "Negro", false, 9, "macho", "mediano", false, false),
                new Cat(2, "gato", "Wi", "Marrón", true, 9, "macho", "grande", false, true),
                new Cat(3, "gato", "Ñoño", "Amarillo", true, 9, "macho", "mediano", false, false),
                new Cat(4, "gato", "Say", "Gris", false, 9, "macho", "mediano", false, false),
                new Cat(5, "gato", "Yuno", "Tricolor", false, 9, "hembra", "pequeño", false, false),
                new Dog(6, "perro", "Pepo", "Tricolor", false, 9, "hembra", "pequeño", false, false),
                new Dog(7, "perro", "Dulce", "Amarillo", false, 9, "hembra", "pequeño", false, false),
                new Dog(8, "perro", "Bolt", "Balnco", false, 9, "hembra", "pequeño", false, false),
                new Dog(9, "perro", "Nita", "Negro", false, 9, "hembra", "pequeño", false, false),
                new Dog(10, "perro", "Mini", "Marrón", false, 9, "hembra", "pequeño", false, false)
            };
        }
    }
}