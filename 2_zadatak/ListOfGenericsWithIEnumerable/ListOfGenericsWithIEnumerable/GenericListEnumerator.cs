using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGenericsWithIEnumerable
{
    class GenericListEnumerator<X> : IEnumerator<X>
    {
        IGenericList<X> _collection;
        int index = 0;
        public GenericListEnumerator(IGenericList<X> collection)
        {
            _collection = collection;
        }

        public bool MoveNext()
        {
            if(index < _collection.Count)
            {
                return true;
            }
            return false;
        }

        public X Current
        {
            get
            {
                return _collection.GetElement(index++);
            }
        }

        object IEnumerator.Current { get { return Current; } }
        
        public void Dispose()
        {
            //ignore
        }
        public void Reset()
        {
            //ignore
        }
    }
}
