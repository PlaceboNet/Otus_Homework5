using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Homework5
{
    public class Labrador : Dog, IMyCloneable<Labrador>, ICloneable
    {
        public string Color { get; set; }

        public Labrador(string species, int age, bool hasFur, string breed, string color)
            : base(species, age, hasFur, breed)
        {
            Color = color;
        }

        protected Labrador(Labrador other)
            : base(other)
        {
            Color = other.Color;
        }

        public new Labrador Clone() => new Labrador(this);

        object ICloneable.Clone() => Clone();
    }
}
