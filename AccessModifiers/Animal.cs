using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Animal
    {
        protected string species { get; set; }

        public string GetSpecies()
        {
            return species;
        }
    }

    internal class Dog : Animal    
    {   
        public Dog() { species = GetSpecies(); }
    }
}
