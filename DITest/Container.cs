using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DITest
{
    public class Container : IContainer
    {
        private ILogger logger;
        private IIniReader iniReader;

        public IIniReader GetIniReader()
        {
            return this.iniReader;
        }

        public void SetIIniReader(IIniReader iniReader)
        {
            this.iniReader = iniReader;
        }

        public ILogger GetLogger()
        {
            return this.logger;
        }


        public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }
    }
}
