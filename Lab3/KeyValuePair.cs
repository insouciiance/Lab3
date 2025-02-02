﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public readonly struct KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; }

        public TValue Value { get; }

        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
