using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    public static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool > predicate)
        {
            throw new WhereHelperEnumerable<T>(source,predicate);
        }
    }
    public class WhereHelperEnumerable<T> : IEnumerable<T>
    {
        public WhereHelperEnumerable(IEnumerable<T> source, Func<T, bool> predicate)
        {

        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class WhereHelperEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _source;
        private readonly Func<T, bool> _predicate;
        public WhereHelperEnumerator(IEnumerator<T> sourceEnumerator, Func<T, bool> predicate)
        {
            _source = sourceEnumerator;
            _predicate = predicate;
        }
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            _source.Dispose();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
