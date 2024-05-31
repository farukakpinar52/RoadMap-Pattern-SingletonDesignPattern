using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SDPExampleWithMethod
    {
        private SDPExampleWithMethod()
        {
            Console.WriteLine("SDP Method ile nesne üretildi");
        }

        static SDPExampleWithMethod? _SDPExampleWithMethod;

        public static SDPExampleWithMethod GetInstance()
        {
            if (_SDPExampleWithMethod == null)
             _SDPExampleWithMethod = new SDPExampleWithMethod();

            return _SDPExampleWithMethod;
        }
    }
}
