using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Singles
    {
        public static T SingleOrDefault<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            List<T> result = new List<T>(2);

            foreach (var item in list)
            {
                if (func(item))
                {
                    if(result.Count < 1)
                    {
                        result.Add(item);
                    }
                    else
                    {
                        throw new Exception("Sequence contains more than one element");
                    }
                }
            }

            if (result.Count == 1)
            {
                return result[0];
            }

            return default(T);
        }

        //public static T Single<T>(this IEnumerable<T> list, Func<T, bool> func) where T : class
        //{
        //    var result = SingleOrDefault<T>(list, func);

        //    if (result == null)
        //    {
        //        throw new Exception("Sequence contains no matching elements");
        //    }

        //    return result;
        //}

        public static T Single<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            bool itemFound = false;
            T matchedItem = default(T);

            foreach (var item in list)
            {
                if (!itemFound && func(item))
                {
                    itemFound = true;
                    matchedItem = item;
                }
                else
                {
                    throw new Exception("Sequence contains more than one element");
                }
            }

            if (!itemFound)
            {
                throw new Exception("Sequence contains no matching elements");
            }

            return matchedItem;
        }
    }
}
