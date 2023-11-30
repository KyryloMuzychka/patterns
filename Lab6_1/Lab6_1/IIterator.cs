using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public interface IIterator<T>
    {
        T Next();
        T Prev();
        T Current();
        void SetCurrent(int index);
        int GetPosition();
    }
}
