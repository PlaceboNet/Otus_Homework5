using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Homework5
{
    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
