﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaTests
{
    public static class TupleListExtensions
    {
        public static void Add<T1, T2>(this IList<Tuple<T1, T2>> list,
                T1 item1, T2 item2)
        {
            list.Add(Tuple.Create(item1, item2));
        }

        public static void Add<T1, T2, T3>(this IList<Tuple<T1, T2, T3>> list,
                T1 item1, T2 item2, T3 item3)
        {
            list.Add(Tuple.Create(item1, item2, item3));
        }

        public static void Add<T1, T2, T3, T4>(this IList<Tuple<T1, T2, T3, T4>> list,
                T1 item1, T2 item2, T3 item3, T4 item4)
        {
            list.Add(Tuple.Create(item1, item2, item3, item4));
        }

        public static void Add<T1, T2, T3, T4, T5>(this IList<Tuple<T1, T2, T3, T4, T5>> list,
                T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            list.Add(Tuple.Create(item1, item2, item3, item4, item5));
        }
    }
}
