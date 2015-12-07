using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        public IntegerList()
        {
            _internalStorage = new int[4];
            Count = 0;
        }
        public IntegerList(int sizeOfLIst)
        {
            _internalStorage = new int[sizeOfLIst];
            Count=0;
        }

        public int Count
        {
            get; set;
            
        }

        public void Add(int item)
        {
            if (_internalStorage.Length  < Count+1)
            {
                int[] tempArray = new int[2*_internalStorage.Length];
                for(int i = 0; i < Count; i++)
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
            int[] temp = new int[Count];
            _internalStorage=temp;
            Count = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return true;
            }
            return false;
        }

        public int GetElement(int index)
        {

            if(index <=Count)
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
            for (int i = 0; i < Count; i++)
                if (_internalStorage[i].Equals(item))
                    return i;
            return (-1);
        }

        public bool Remove(int item)
        {
            int j = 0;
            for(int i=0; i < Count; i++)
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
            if(index>Count)
            {
                return false;
            }
            for (int i = index; i < Count; i++)
                _internalStorage[i]=_internalStorage[i+1];
            _internalStorage[Count]=0;
            Count--;
            return true;

        }
    }
}
