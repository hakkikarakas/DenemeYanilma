using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExamples
{
    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; 
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            //array in son elemanına item gönderdik.
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }            
        }


    }

}
