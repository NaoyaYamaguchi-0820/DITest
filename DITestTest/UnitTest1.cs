using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DITest;

namespace DITestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IContainer container = new Container();
            ILogger testLogger = new LoggerForTest();

            container.SetLogger(testLogger);

            Menu menu = new Menu();

            menu.BusinessLogic(container);

        }

        [TestMethod]
        public void TestMethod2()
        {
            IContainer container = new Container();

            // make LoggerMock
        }


        public class LoggerForTest : ILogger
        {
            public void Write(string message)
            {
                Console.WriteLine("私はモックです");
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            IIniReader ini = new IniReaderMock((string section, string key) =>
            {
                Console.WriteLine("im mock. key is " + key);
                return "Im mock";
            });

            IContainer container = new Container();
            container.SetIIniReader(ini);


            ini.GetValue("aa", "bb");
        }

        [TestMethod]
        public void TestTime()
        {

            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);
            TimeSpan target = new TimeSpan(15, 0, 0);

            if(start <= target && target <= end)
            {
                Console.WriteLine("時間内です");
            }



        }

    }
}
