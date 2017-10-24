using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Samples
{
    public static partial class MyCollectionExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (pred == null) throw new ArgumentNullException(nameof(pred));

            return FilterImpl(source, pred);
        }

        private static IEnumerable<T> FilterImpl<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            foreach (T item in source)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Filter2<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (pred == null) throw new ArgumentNullException(nameof(pred));

            return FilterImpl2(source, pred);

            IEnumerable<T> FilterImpl2(IEnumerable<T> source2, Func<T, bool> pred2)
            {
                foreach (T item in source2)
                {
                    if (pred2(item))
                    {
                        yield return item;
                    }
                }
            }
        }

        public static IEnumerable<T> Filter3<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (pred == null) throw new ArgumentNullException(nameof(pred));

            return FilterImpl2();

            IEnumerable<T> FilterImpl2()   // local function with closure
            {
                foreach (T item in source)
                {
                    if (pred(item))
                    {
                        yield return item;
                    }
                }
            }
        }
    }


}
