using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Person
    {
        private string _name { get; }
        private int _age { get; } 

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}
