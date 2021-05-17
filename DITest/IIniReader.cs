using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DITest
{
    public interface IIniReader
    {
        string GetValue(string section, string key);

    }
}
