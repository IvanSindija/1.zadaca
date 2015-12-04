using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GenericList<X> : IGenericList<X>

    {
        private X[] _internalStorage;

        public GenericList()
        {
            _internalStorage = new X[4];
            Count = 0;
        }
        public GenericList(int sizeOfLIst)
        {
            _internalStorage = new X[sizeOfLIst];
            Count = 0;
        }

        public int Count
        {
            get; set;

        }

        public void Add(X item)
        {
            if (_internalStorage.Length < Count + 1)
            {
                X[] tempArray = new X[2 * _internalStorage.Length];
                for (int i = 0; i < Count; i++)
                {
                    tempArray[i] = _internalStorage[i];
                }
                _internalStorage = tempArray;
            }
            _internalStorage[Count] = item;
            Count++;
        }

        public void Clear()
        {
            X[] temp = new X[Count];
            _internalStorage = temp;
            Count = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return true;
            }
            return false;
        }

        public X GetElement(int index)
        {

            if (index <= Count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();

            }

        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < Count; i++)
                if (_internalStorage[i].Equals(item))
                    return i;
            return (-1);
        }

        public bool Remove(X item)
        {
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    j++;
                    _internalStorage[i] = _internalStorage[i + j];
                }
                _internalStorage[i] = _internalStorage[i + j];
            }

            Count = Count - j;
            if (j > 0)
                return true;
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > Count)
            {
                return false;
            }
            for (int i = index; i < Count; i++)
                _internalStorage[i] = _internalStorage[i + 1];
            Count--;
            return true;

        }
    }
}