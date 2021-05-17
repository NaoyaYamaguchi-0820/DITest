using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DITest
{
    public interface IContainer
    {
        ILogger GetLogger();
        void SetLogger(ILogger logger);

        IIniReader GetIniReader();
        void SetIIniReader(IIniReader iniReader);

    }
}
