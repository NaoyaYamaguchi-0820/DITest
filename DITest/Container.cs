using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DITest
{
    public class Container : IContainer
    {
        private ILogger logger;

        public IIniReader GetIniReader()
        {
            throw new NotImplementedException();
        }

        public void SetIIniReader(IIniReader iniReader)
        {
            throw new NotImplementedException();
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
