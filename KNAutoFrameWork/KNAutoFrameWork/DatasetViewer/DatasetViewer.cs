using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class DatasetViewer : UIelement
    {
        internal DatasetViewer(HtmlElement htmlelement) :
            base(htmlelement)
        {


        }

        


        public void selectDimension(string dimensionName)
        {
            Html.Driver.WaitForAjax();
            var els  = Html.Element.FindElements(By.CssSelector("div.accordion > h3.ui-accordion-header > a"));
            foreach (var e in els)
            {
                e.Click();
                break;
            }
            Html.Driver.WaitForAjax();
 
        }

        public static IWebElement FindDimensionListMember(IWebDriver driver, IWebElement parent, string name)
        {
            const string selectmem = ".//span[./text()='{0}']";
            IWebElement elem = null;
            try
            {
                elem = driver.FindElement(By.XPath(string.Format(selectmem, name)));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(false);", elem);
            }
            catch (Exception)
            {
            }
            if (elem == null)
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;

                Action<long> scrollParent = (top) => js.ExecuteScript("arguments[0].scrollTop = " + top.ToString() + ";", parent);
                long scrollTop = 0;
                var scrollHeight = (long)js.ExecuteScript("return arguments[0].scrollHeight;", parent);
                var scrollDelta = (long)js.ExecuteScript("return arguments[0].clientHeight;", parent);
                while (scrollTop < scrollHeight && elem == null)
                {
                    scrollParent(scrollTop);
                    try
                    {
                        if (driver.WaitUntil(By.XPath(string.Format(selectmem, name)), 0) != null)
                            elem = parent.FindElement(By.XPath(string.Format(selectmem, name)));
                    }
                    catch (Exception)
                    {
                    }
                    scrollTop += scrollDelta;
                }
            }
            if (elem == null)
                throw new Exception(string.Format("Dimension element {0} not found", name));
            return elem;
        }

        public void SelectMembers(params string[] names)
        {
            Html.Driver.WaitForAjax();
            //Html.Driver.WaitUntilDisabled(By.ClassName("loading"));
            var parent = Html.Driver.WaitUntil(By.CssSelector("div.accordion > ul.ui-accordion-content-active > div.dimension-memberlist-wrapper > div.dimension-members-list"));

            if (Html.Driver.PageSource.Contains("build-version"))
            {
                var buildText = Html.Driver.FindElement(By.ClassName("build-version"));
                (Html.Driver as IJavaScriptExecutor).ExecuteScript("arguments[0].style.visibility='hidden'", buildText);
                (Html.Driver as IJavaScriptExecutor).ExecuteScript("document.getElementsByClassName('build-version')[0].style.visibility='hidden';", buildText);
            }

            foreach (var name in names)
                FindDimensionListMember(Html.Driver, parent, name).Click();

            Html.Driver.WaitUntilDisabled(By.ClassName("loading"));
            Html.Driver.WaitForAjax();
        }



    }
}
