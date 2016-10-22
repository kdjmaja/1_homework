using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerListNamespace
{
    public interface IIntegerList
    {
        /// <summary >
        /// Adds an item to the collection .
        /// </ summary >
        void Add(int item);
        /// <summary >
        /// Removes the first occurrence of an item from the collection .
        /// If the item was not found , method does nothing .
        /// </ summary >
        bool Remove(int item);
        /// <summary >
        /// Removes the item at the given index in the collection .
        /// </ summary >
        bool RemoveAt(int index);
        /// <summary >
        /// Returns the item at the given index in the collection .
        /// </ summary >
        int GetElement(int index);
        /// <summary >
        /// Returns the index of the item in the collection .
        /// If item is not found in the collection , method returns -1.
        /// </ summary >
        int IndexOf(int item);
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
        bool Contains(int item);
    }
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int count = 0;


        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            int size = _internalStorage.Length;
            if (count == size)
            {
                int[] _internalStorage1 = new int[2 * size];
                _internalStorage.CopyTo(_internalStorage1, 0);
                _internalStorage = _internalStorage1;
                _internalStorage[size] = item;
            }
            else
            {
                _internalStorage[Count] = item;
            }
            ++count;
        }

        public bool Remove(int item)
        {
            int size = _internalStorage.Count();
            int index = IndexOf(item);
            RemoveAt(index);
            return false;
        }

        public bool RemoveAt(int index)
        {
            int size = Count;
            if (index > (size - 1) || index < 0)
            {
                return false;
            }
            if (index == (size - 1))
            {
                _internalStorage[size - 1] = 0;
                return true;
            }
            else
            {
                for (int j = index; j < (size - 1); j++)
                {
                    _internalStorage[j] = _internalStorage[j + 1];
                }
                --count;
                _internalStorage[size - 1] = 0;
                return true;
            }
        }

        public int GetElement(int index)
        {
            int size = _internalStorage.Count();
            if (index >= size || index < 0)
            {
                throw new IndexOutOfRangeException("Taj element ne postoji.");
            }
            else
            {
                return _internalStorage[index];
            }
        }

        public int IndexOf(int item)
        {
            int size = _internalStorage.Count();
            for (int i = 0; i < size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Clear()
        {
            int size = _internalStorage.Count();
            for (int i = 0; i < size; i++)
            {
                _internalStorage[i] = 0;
            }
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
    }


}
