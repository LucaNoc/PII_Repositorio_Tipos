using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
    public class Repository<T>
    {
        private List<T> items = new();

        public void Add(T item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }

        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        public T Find(Predicate<T> criteria)
        {
            return this.items.Find(criteria);
        }
    }
}