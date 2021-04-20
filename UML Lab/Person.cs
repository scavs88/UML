using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Person
    {
        private string _name;
        private string _address;
        private string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        private string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public Person(string name, string address)
        {
            this._name = name;
            this._address = address;
        }

        public override string ToString()
        {
            
            return $"Person {this._name} {this._address}";
        }


    }
}
