using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Homework5
{
    public class Mammal : Animal, IMyCloneable<Mammal>, ICloneable
    {
        public bool HasFur { get; set; }

        public Mammal(string species, int age, bool hasFur)
            : base(species, age)
        {
            HasFur = hasFur;
        }

        protected Mammal(Mammal other)
            : base(other)
        {
            HasFur = other.HasFur;
        }

        public new Mammal Clone() => new Mammal(this);

        object ICloneable.Clone() => Clone();
    }
}
