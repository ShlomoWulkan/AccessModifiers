using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Person
    {
        private int age { get; set; }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }


    }
}
