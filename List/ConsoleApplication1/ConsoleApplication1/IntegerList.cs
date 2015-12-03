using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _numOfItems;

        public IntegerList()
        {
            _internalStorage = new int[4];
            _numOfItems = 0;
        }
        public IntegerList(int sizeOfLIst)
        {
            _internalStorage = new int[sizeOfLIst];
            _numOfItems=0;
        }

        public int Count
        {
            get
            {
                return _numOfItems;
            }
            
        }

        public void Add(int item)
        {
            if (_internalStorage.Length  <= _numOfItems+1)
            {
                int[] tempArray = new int[2*_internalStorage.Length];
                for(int i = 0; i < _numOfItems; i++)
                {
                    tempArray[i] = _internalStorage[i];
                }
                _internalStorage = tempArray;
            }
            _internalStorage[_numOfItems] = item;
            _numOfItems++;
        }

        public void Clear()
        {
            int[] temp = new int[_numOfItems];
            _internalStorage=temp;
            _numOfItems = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _numOfItems; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return true;
            }
            return false;
        }

        public int GetElement(int index)
        {

            if(index <=_numOfItems)
{
                return _internalStorage[index];
            }
            else
{
                throw new IndexOutOfRangeException();
           
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _numOfItems; i++)
                if (_internalStorage[i].Equals(item))
                    return i;
            return (-1);
        }

        public bool Remove(int item)
        {
            int j = 0;
            for(int i=0; i < _numOfItems; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    j++;
                    _internalStorage[i] = _internalStorage[i + j];
                }
                _internalStorage[i] = _internalStorage[i + j];
            }            _numOfItems = _numOfItems - j;            if (j > 0)                return true;            return false;
        }

        public bool RemoveAt(int index)
        {
            if(index>_numOfItems)
            {
                return false;
            }
            for (int i = index; i < _numOfItems; i++)
                _internalStorage[i]=_internalStorage[i+1];
            _internalStorage[_numOfItems]=0;
            _numOfItems--;
            return true;
        }
    }
}
