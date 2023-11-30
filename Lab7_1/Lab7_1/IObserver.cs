using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{

    public interface IObserver
    {
        void Update(double price);
    }
}
