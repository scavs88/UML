using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Lab
{
    class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;
        private string Program
        {
            get { return this._program; }
            set { this._program = value; }
        } 
        private int Year
        {
            get { return this._year; }
            set { this._year = value; }
        }
        private double Fee
        {
            get { return this._fee; }
            set { this._fee = value; }
        }
        public Student(string name, string address, string program, int year, double fee) : base(name,address)
        {
            this._program = program;
            this._year = year;
            this._fee = fee;
        }



        public override string ToString()
        {
            string result=base.ToString();
            return $"Student {result}, {this._program}, {this._year}, {this._fee}. ";
        }
    }
}
