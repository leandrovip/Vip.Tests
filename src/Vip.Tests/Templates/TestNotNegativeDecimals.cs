﻿using System.Collections;
using System.Collections.Generic;

namespace Vip.Tests.Templates
{
    public class TestNotNegativeDecimals : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {-1m},
            new object[] {-0.1m},
            new object[] {-10m}
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}