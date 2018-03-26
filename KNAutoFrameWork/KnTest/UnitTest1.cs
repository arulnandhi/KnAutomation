using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnTest
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        
            public void Hometest()
            {
            
            
                App.Home().Home.selectLogin();
               App.Login().Login.LogIn("arul05@knoema.com", "test1234");
               String Title = App.Home().Home.getTitle();
               //Console.WriteLine(Title);
            Assert.AreEqual(Title, "Free data, statistics, analysis, visualization & sharing - knoema.com");
            
            }
        
    }
}
