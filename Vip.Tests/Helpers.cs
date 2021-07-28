using System;
using System.Collections;

namespace Vip.Tests
{
    public static class Helpers
    {
        public static Array GerarListaEntidades(Func<Action, object> builderMethod)
        {
            var repetitions = new Random().Next(1, 10);
            var lista = new ArrayList();

            for (var i = 0; i < repetitions; i++)
            {
                var obj = builderMethod.Invoke(null);
                lista.Add(obj);
            }

            return lista.ToArray();
        }
    }
}