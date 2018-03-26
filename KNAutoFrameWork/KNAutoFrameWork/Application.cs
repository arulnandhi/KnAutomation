using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class Application
    {
        RemoteWebDriver _driver;

        public Application()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://beta.knoema.org");
        }

        //public LoginPage Login()
        //{
        //    _driver.WaitForAjax();
        //    return new LoginPage(new HtmlPage(_driver));
        //}


        public LoginPage Login()
        {
            LoginPage LP = new LoginPage(new HtmlPage(_driver));
            return LP;
        }

        //public HomePage Home()
        //{
        //    _driver.WaitForAjax();
        //    return new HomePage(new HtmlPage(_driver));
        //}

        public HomePage Home()
        {
            HomePage HP = new HomePage(new HtmlPage(_driver));
            return HP;
        }

        public DatasetViewerPage DsViewer()
        {
            return new DatasetViewerPage(new HtmlPage(_driver));
        }


        


    }
}
