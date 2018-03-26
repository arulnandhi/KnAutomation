using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class HtmlElement
    {
        private IWebDriver _driver;
        private IWebElement _element;
        private string _selector;

        public HtmlElement(IWebDriver Driver, string Selector)
        {
            this._driver = Driver;
            this._selector = Selector;

            try
            {
                if (string.IsNullOrEmpty(Selector))
                {
                    _element = _driver.FindElement(By.CssSelector("body"));
                }
                else
                {
                    _element = _driver.FindElement(By.CssSelector(_selector));
                }

            }
            catch (NoSuchElementException e)
            {
                _driver.Navigate().Refresh();
                if (string.IsNullOrEmpty(Selector))
                {
                    _element = _driver.FindElement(By.CssSelector("body"));
                }
                else
                {
                    _element = _driver.FindElement(By.CssSelector(_selector));
                }

                
                throw;
            }


        }

        public HtmlElement Descendant(string Selector)
        {
            var desSelector = string.IsNullOrEmpty(_selector) ? Selector : string.Format("{0}, {1}", _selector, Selector);
            return new HtmlElement(_driver, desSelector);
        }

        public HtmlElement child(string Selector)
        {
            var desSelector = string.IsNullOrEmpty(_selector) ? Selector : string.Format("{0}, {1}", _selector, Selector);
            return new HtmlElement(_driver, desSelector);
        }

        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }

        public IWebElement Element
        {
            get
            {
                return _element;
            }
        }

    

    }
}
