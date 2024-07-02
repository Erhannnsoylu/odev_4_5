using System;

using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "Merhaba!");
                dict.Add(2, "Nasılsın?");
                dict.Add(3, "Bugün ne yapmak istersin?");

                foreach (KeyValuePair<int, string> obj in dict)
                {
                    Console.WriteLine("{0}, {1}", obj.Key, obj.Value);
                }
                MyDict<string, string> myDict = new MyDict<string, string>();
                myDict.Add("adım", "Tarık");
            }
        }
        class MyDict<TKeys, TValues>
        {
            TKeys[] _keys;
            TValues[] _values;

            TKeys[] _TempKeys;
            TValues[] _TempValues;

            public MyDict() //consructor
            {
                _keys = new TKeys[0];
                _values = new TValues[0];
            }
            public void Add(TKeys key, TValues value)
            {
                _TempKeys = _keys;
                _TempValues = _values;

                _keys = new TKeys[_keys.Length + 1];
                _values = new TValues[_values.Length + 1];

                for (int i = 0; i < _keys.Length; i++)
                {
                    _keys[i] = _TempKeys[i];
                    _values[i] = _TempValues[i];
                }
                _keys[_keys.Length - 1] = (TKeys)key;
                _values[_keys.Length - 1] = (TValues)value;
            }
        }
    }