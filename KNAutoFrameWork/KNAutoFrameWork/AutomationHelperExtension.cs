using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public static class AutomationHelperExtension
    {

        //Mthod to wait until the element available
        public static IWebElement waituntil(this IWebDriver driver, By by, int timespan = 20)
        {
            var el = new WebDriverWait(driver, TimeSpan.FromSeconds(timespan)).Until(ExpectedConditions.ElementExists((by)));
            return el;

        }

        //Method to check the page load status
        public static void WaitForAjax(this IWebDriver driver, By elem = null)
        {
            while (true)
            {
                try
                {
                    var pageloadIsComplate =  (driver as IJavaScriptExecutor).ExecuteScript("return document.readyState");
                    if (pageloadIsComplate.Equals("complete"))
                    {
                        break;
                    }

                }
                catch (WebDriverException ex)
                {
                    Console.Write(ex.Message);

                    continue;

                }
                
            }
        }


        //Method to check Wait until you find the element
        public static IWebElement WaitUntil(this IWebDriver driver, By by, int timespan = 20)
        {
            try
            {
                var el = new WebDriverWait(driver, TimeSpan.FromSeconds(timespan)).Until(ExpectedConditions.ElementExists(by));
                return el;

            }
            catch (WebDriverTimeoutException te)
            {
                te.Data.Add("Selector", by.ToString() + "causes webDriverTimeoutException with time span" + Convert.ToString(timespan));

                return null;
            }
        }


        public static bool WaitUntilDisabled(this IWebDriver driver, By by, int timespan = 2)
        {
            return true;
 
        }

        public static void DrawBorder(this IWebElement element, IWebDriver driver)
        {
            var js = (driver as IJavaScriptExecutor);
            js.ExecuteScript("return style.border = '3px solid red", element);
        }



    }
}
