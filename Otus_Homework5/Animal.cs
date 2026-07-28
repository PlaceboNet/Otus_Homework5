using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Homework5
{
    public class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Species { get; set; }
        public int Age { get; set; }

        public Animal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        protected Animal(Animal other)
        {
            Species = other.Species;
            Age = other.Age;
        }

        public Animal Clone() => new Animal(this);

        object ICloneable.Clone() => Clone();
    }
}
