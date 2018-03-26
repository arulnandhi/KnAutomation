using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnTest
{
    [TestClass]
    public class UnitTest2 : TestBase
     {
        [TestMethod]
        public void EIAIES2013JulLineChartSelected()
        {
            App.DsViewer().DsViewer.SelectMembers("Mexico", "Aruba", "Belize", "Tonga");
            App.DsViewer().DsViewer.selectDimension("Variable");
            App.DsViewer().DsViewer.SelectMembers("Total Primary Coal Production (Quadrillion Btu)");
            //App.DsViewer().DsViewer.selectDimension("Location");
            
            
            
        }
    }
}
