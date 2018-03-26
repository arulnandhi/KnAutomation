using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KNAutoFrameWork;

namespace KnTest
{
    public class TestBase
    {
        public TestBase()
        {
            App = new Application();
            
        }

        public static KNAutoFrameWork.Application App { get; set; }
    }
}
