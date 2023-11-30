using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class Iterator<T> : IIterator<T>
    {
        private List<T> items;
        private int currentIndex;

        public Iterator(List<T> items) 
        {
            this.items = items;
            currentIndex = 0;
        }

        public T Next()
        {
            return (currentIndex + 1 < items.Count) ? (items[++currentIndex]) : (items[currentIndex = 0]);
        }

        public T Prev()
        {
            return (currentIndex > 0) ? (items[--currentIndex]) : (items[currentIndex = items.Count - 1]);
        }
           
        public T Current()
        {
            return (currentIndex < items.Count) ? items[currentIndex] : items[currentIndex = 0];
        }

        public void SetCurrent(int index)
        {
            currentIndex = index;
        }

        public int GetPosition()
        {
            return currentIndex;
        }
    }
}
