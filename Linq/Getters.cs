﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Getters
    {
        public static T SingleOrDefault<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            bool itemFounded = false;
            T foundItem = default(T);

            foreach (var item in list)
            {
                if (func(item))
                {
                    if (!itemFounded)
                    {
                        itemFounded = true;
                        foundItem = item;
                    }
                    else
                    {
                        throw new Exception("Sequence contains more than one element");
                    }
                }
            }

            if (itemFounded)
            {
                return foundItem;
            }

            return default(T);
        }

        public static T SingleOrDefault<T>(this IEnumerable<T> list)
        {
            throw new NotImplementedException();
        }

        public static T Single<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            bool itemFound = false;
            T matchedItem = default(T);

            foreach (var item in list)
            {
                if (func(item))
                {
                    if (!itemFound)
                    {
                        matchedItem = item;
                        itemFound = true;
                    }
                    else
                    {
                        throw new Exception("Sequence contains more than one element");
                    }
                }
            }

            if (!itemFound)
            {
                throw new Exception("Sequence contains no matching elements");
            }

            return matchedItem;
        }

        public static T Single<T>(this IEnumerable<T> list)
        {
            throw new NotImplementedException();
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (var item in list)
            {
                if(func(item))
                {
                    return item;
                }
            }

            return default(T);
        }

        public static T FirstOrDefault<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                return default(T);
            }

            return enumerator.Current;
        }

        public static T First<T>(this IEnumerable<T> list, Func<T, bool> func)
        {
            foreach (var item in list)
            {
                if(func(item))
                {
                    return item;
                }
            }

            throw new Exception("Sequence contains no matching elements");
        }

        public static T First<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();
            
            if(!enumerator.MoveNext())
            {
                throw new Exception("Sequence contains no elements");
            }

            return enumerator.Current;
        }
    }
}
