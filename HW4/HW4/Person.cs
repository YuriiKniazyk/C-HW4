using System;

namespace HW4
{
    public class Person
    {
        private string _name;
        private DateTime _birthday;

        public string Name => _name;
        public DateTime Birthday => _birthday;

        public Person() { }
        public Person(string name, DateTime birth)
        {
            _name = name;
            _birthday = birth;
        }

        public void Input(string name, DateTime birthday)
        {
            _name = name;
            _birthday = birthday;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - _birthday.Year;
            if (_birthday.DayOfYear > DateTime.Today.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public bool ChangeName(string name = "Very Young")
        {
            if (Age() < 16)
            {
                _name = name;
                return true;
            }

            return false;
        }

        public void Output() => ToString();

        public static bool operator ==(Person firstPerson, Person secondPerson)
        {
            return (firstPerson?._name == secondPerson?._name);
        }

        public static bool operator !=(Person firstPerson, Person secondPerson)
        {
            return !(firstPerson?._name == secondPerson?._name);
        }

        public override string ToString()
        {
            return $"Name person: {_name} Age person: {Age()}";
        }

    }
}