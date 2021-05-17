using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITest;

namespace DITestTest
{
    public delegate string GetValueMock(string section, string key);

    class IniReaderMock : IIniReader
    {
        public GetValueMock getValueMock;

        public IniReaderMock(GetValueMock getValueMock)
        {
            this.getValueMock = getValueMock;
        }

        public string GetValue(string section, string key)
        {
            return this.getValueMock(section, key);
        }



    }
}
