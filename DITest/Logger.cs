using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DITest
{
    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine("私は本番用ロガーです。内容:" + message);
        }

    }
}
