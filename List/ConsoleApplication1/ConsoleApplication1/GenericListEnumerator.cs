using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class GenericListEnumerator<T> : IEnumerator<T>
    {
        private GenericList<T> genericList;
        private int positon;

        public GenericListEnumerator(GenericList<T> genericList)
        {
            this.genericList = genericList;
            positon = -1;
        }

        public T Current
        {
            get
            {
                return genericList.GetElement(positon);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            if (positon + 1 < genericList.Count)
            {
                positon++;
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}