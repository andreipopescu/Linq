using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Validators
    {
        public static bool All<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (var item in list)
            {
                if (!func(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Any<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();

            return enumerator.MoveNext();
        }

        public static bool Any<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (var item in list)
            {
                if (func(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
