using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class HomePage : UIPage
    {
        public HomePage(HtmlPage page) :
            base(page)
        {


        }
        

        public Home Home
        {
            get
            {
                Html.Driver.WaitForAjax();
                Html.Driver.waituntil(By.CssSelector("div.primary-nav"));
                return new Home(Html.Descendant("div.primary-nav"));
            }
        }

    }
}
