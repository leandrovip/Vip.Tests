using System.Collections;
using System.Collections.Generic;

namespace Vip.Tests.Templates
{
    public class TestNotNullOrEmptyString : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {null},
            new object[] {""}
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