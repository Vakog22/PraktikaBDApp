using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VlasProg.ClassHelper
{
    class DBHelper
    {
        public class DBHelperClass
        {
            public static FactoryEntities Context { get; } = new FactoryEntities();

        }
    }
}
