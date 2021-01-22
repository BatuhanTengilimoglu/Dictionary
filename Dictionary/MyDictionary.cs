using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,J>
    {
        T[] keys ;
        T[] _tempKey;
        J[] values;
        J[] _tempValue;
        public MyDictionary() //constractor 
        {
            keys= new T[0];
            values = new J[0];
        }
        public void Add(T key,J value)
        {
            _tempKey = keys;
            _tempValue = values;

            keys = new T[keys.Length + 1];
            values = new J[values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                keys[i] = _tempKey[i];
                values[i] = _tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
        }
    
    }
}
