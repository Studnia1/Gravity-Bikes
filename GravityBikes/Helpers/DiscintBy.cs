using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GravityBikes.Helpers
{
    public static partial class DistinctByExtensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TDistinct>(this IEnumerable<TSource> collection, Func<TSource, TDistinct> selector)
        {
            return collection.DistinctBy(selector, null);
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> collection, Func<TSource, TKey> selector, IEqualityComparer<TKey> comparer)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return DistinctByImpl(collection, selector, comparer);
        }

        private static IEnumerable<TSource> DistinctByImpl<TSource, TKey>(IEnumerable<TSource> collection, Func<TSource, TKey> selector, IEqualityComparer<TKey> comparer)
        {
            comparer = comparer ?? EqualityComparer<TKey>.Default;

            HashSet<TKey> cache = new HashSet<TKey>(comparer);

            foreach (TSource item in collection)
            {
                if (cache.Add(selector(item)))
                {
                    yield return item;
                }
            }
        }
    }
}
