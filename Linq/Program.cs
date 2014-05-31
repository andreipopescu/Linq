using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinq2 test = new TestLinq2();
            test.TestAllMethod();
            test.TestAnyMethod();
            test.TestWhereMethod();
            test.TestSelectMethod();
            test.TestGroupByMethod();
        }
    }
}
