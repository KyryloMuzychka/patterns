using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class IteratorFactory
    {
        public static IIterator<T> CreateIterator<T>(List<T> items)
        {
            return new Iterator<T>(items);
        }
    }
}
