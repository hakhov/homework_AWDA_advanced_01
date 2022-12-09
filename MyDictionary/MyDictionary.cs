using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey, TValue> :IEnumerable< KeyValuePair<TKey, TValue>>
    {
        private List<KeyValuePair<TKey, TValue>>[] _obj;

       
        public MyDictionary()
        {
            _obj = new List<KeyValuePair<TKey, TValue>>[10];
        }
        public int Count { set { Count = _obj.Length; } }
        public void Add(TKey key, TValue val)
        {
            var address = key.GetHashCode();
            if (_obj[address] == null)
            {
               _obj[address] = new List<KeyValuePair<TKey, TValue>>()   ;
            }
            else
            {
                throw new ArgumentException("Duplicate Key");
            }  

         }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return (from collections in _obj
                    where collections != null
                    from item in collections
                    select item).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _obj.GetEnumerator();
        }
    }
}
