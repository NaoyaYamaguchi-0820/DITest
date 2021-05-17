using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITest;

namespace DITestTest
{
    public delegate void Write_Mock(string message);

    public class LoggerMock : ILogger
    {
        public Write_Mock write;

        public LoggerMock(Write_Mock write_Mock)
        {
            this.write = write_Mock;
        }

        public void Write(string message)
        {
            this.write(message);
        }
    }
}
