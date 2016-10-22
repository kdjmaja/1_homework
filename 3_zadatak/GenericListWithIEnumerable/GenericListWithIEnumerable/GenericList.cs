using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGenericsWithIEnumerable
{
    public interface IGenericList<X> : IEnumerable<X>
    {
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary >
        void Add(X item);
        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing .
        /// </ summary >
        bool Remove(X item);
        /// <summary >
        /// Removes the item at the given index in the collection .
        /// </ summary >
        bool RemoveAt(int index);
        /// <summary >
        /// Returns the item at the given index in the collection .
        /// </ summary >
        X GetElement(int index);
        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(X item);
        /// <summary >
        /// Readonly property . Gets the number of items contained in the collection.
        /// </ summary >
        int Count { get; }
        /// <summary >
        /// Removes all items from the collection .
        /// </ summary >
        void Clear();
        /// <summary >
        /// Determines whether the collection contains a specific value .
        /// </ summary >
        bool Contains(X item);
    }

    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int counter = 0;
        public GenericList()
        {
            _internalStorage = new X[4];
        }
        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(X item)
        {
            int size = _internalStorage.Length;
            if (counter >= size)
            {
                Array.Resize<X>(ref _internalStorage, counter * 2);
            }
            _internalStorage[counter] = item;
            ++counter;
        }

        public bool Remove(X item)
        {
            if (Contains(item) == true)
            {
                int index = IndexOf(item);
                return RemoveAt(index);
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= counter)
            {
                return false;
            }
            else
            {
                for (int i = index; i < (counter - 1); i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                _internalStorage[counter - 1] = default(X);
                --counter;
                return true;
            }
        }

        public X GetElement(int index)
        {
            if (index < 0 || index >= counter)
            {
                throw new IndexOutOfRangeException("Ne postoji element na tom mjestu.");
            }
            else
            {
                return _internalStorage[index];
            }
        }

        public int IndexOf(X item)
        {
            if (Contains(item) == false)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < counter; i++)
                {
                    if (_internalStorage[i].Equals(item) == true)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < counter; i++)
            {
                _internalStorage[i] = default(X);
            }
            counter = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i].Equals(item) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
