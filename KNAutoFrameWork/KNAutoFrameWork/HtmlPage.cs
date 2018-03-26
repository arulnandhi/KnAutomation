using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class HtmlPage : HtmlElement
    {
        public HtmlPage(IWebDriver driver) : base
            (driver, string.Empty)
        {

        }
    }
}
