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
