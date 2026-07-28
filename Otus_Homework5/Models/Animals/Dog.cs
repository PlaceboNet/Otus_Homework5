using Otus_Homework5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Homework5.Models.Animals
{
    public class Dog : Mammal, IMyCloneable<Dog>, ICloneable
    {
        public string Breed { get; set; }

        public Dog(string species, int age, bool hasFur, string breed)
            : base(species, age, hasFur)
        {
            Breed = breed;
        }

        protected Dog(Dog other)
            : base(other)
        {
            Breed = other.Breed;
        }

        public new Dog Clone() => new Dog(this);

        object ICloneable.Clone() => Clone();
    }
}
