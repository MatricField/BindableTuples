﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixField.Bindable
{
    public static class Bindable
    {
        public static Bindable<T1> Create<T1>(T1 item1)
        {
            return new Bindable<T1>(item1);
        }

        public static Bindable<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new Bindable<T1, T2>(item1, item2);
        }

        public static Bindable<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Bindable<T1, T2, T3>(item1, item2, item3);
        }

        public static Bindable<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            return new Bindable<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        public static Bindable<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Bindable<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        public static Bindable<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Bindable<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        public static Bindable<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Bindable<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }
    }
}
