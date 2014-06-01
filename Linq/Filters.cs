using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Filters
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            List<T> data = new List<T>();

            foreach (var item in list)
            {
                if (func(item))
                {
                    data.Add(item);
                }
            }

            return data;
        }

        public static IEnumerable<R> Select<T, R>(this IEnumerable<T> list, Func<T, R> func)
        {
            List<R> result = new List<R>();

            foreach (var item in list)
            {
                result.Add(func(item));
            }

            return result;
        }

        public static Dictionary<R, List<T>> GroupBy<T, R>(this IEnumerable<T> list, Func<T, R> func)
        {
            Dictionary<R, List<T>> result = new Dictionary<R, List<T>>();

            foreach (var item in list)
            {
                var key = func(item);

                if (result.ContainsKey(key))
                {
                    result[key].Add(item);
                }
                else
                {
                    result.Add(key, new List<T> { item });
                }
            }

            return result;
        }
    }
}
