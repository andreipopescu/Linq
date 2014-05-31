using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class TestLinq
    {
        private List<int> _listaInt32 = new List<int> 
        {
            1,2,3,4,5,6,7,8,9
        };

        private List<Tuple<int, string>> _listaTuple = new List<Tuple<int, string>> 
        {
            Tuple.Create(1, "Praslea"),
            Tuple.Create(2, "Dandanache"),
            Tuple.Create(3, "Tepes"),
            Tuple.Create(4, "Burebista"),
            Tuple.Create(5, "Praslea"),
            Tuple.Create(6, "Solomon"),
            Tuple.Create(7, "Burebista"),
        };

        internal void TestAllMethod()
        {
            bool all = _listaInt32.All(x => x > 0);
        }

        internal void TestAnyMethod()
        {
            bool any = _listaInt32.Any(x => x == 0);
        }

        internal void TestWhereMethod()
        {
            IEnumerable<int> list = _listaInt32.Where(x => x % 2 == 0);
        }

        internal void TestSelectMethod()
        {
            IEnumerable<string> list = _listaTuple.Select(x => x.Item2);
        }

        internal void TestGroupByMethod()
        {
            Dictionary<string, List<Tuple<int, string>>> dic = _listaTuple.GroupBy(x => x.Item2);
        }
    }
}
