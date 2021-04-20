using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Staff : Person
    {
        private string _school;
        private double _pay;
        private string School
        {
            get { return this._school; }
            set { this._school = value; }
        }
        private double Pay
        {
            get { return this._pay; }
            set { this._pay = value; }
        }
        public Staff(string name, string address, string school, double pay) : base (name, address)
        {
            this._school = school;
            this._pay = pay;
        }

        public override string ToString()
        {
            string result=base.ToString();
            return $"Staff {result} works at {this._school} for {this._pay} dollars a year";
        }
    }
}
