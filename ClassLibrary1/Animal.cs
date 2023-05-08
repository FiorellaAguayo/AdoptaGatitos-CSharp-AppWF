namespace ClassLibrary1
{
    public class Animal
    {
        private int _id;
        private string _type; // gato, perro
        private string _name;
        private string _color;
        private bool _race;
        private int _age;
        private string _gender;
        private string _size; //pequeño, mediano, grande
        private bool _adopted;

        public Animal(int id, string type, string name, string color, bool race, int age, string gender, string size, bool adopted)
        {
            Id = id;
            Type = type;
            Name = name;
            Color = color;
            Race = race;
            Age = age;
            Gender = gender;
            Size = size;
            Adopted = adopted;
        }

        public int Id { get { return _id; } set { _id = value;  } }
        public string Type { get { return _type; } set { _type = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public bool Race { get { return _race; } set { _race = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Size { get { return _size; } set { _size = value; } }
        public bool Adopted { get { return _adopted; } set { _adopted = value; } }

    }
}