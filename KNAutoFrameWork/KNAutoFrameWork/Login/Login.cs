using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class Login : UIelement
    {
        internal Login(HtmlElement htmlElement) : 
            base(htmlElement)
        {

        }

        

        public HomePage LogIn(string useremail, string userpassword)
        {
            var form = Html.Element.FindElement(By.CssSelector("Div#login-form"));
            form.FindElement(By.CssSelector("input.single-line")).SendKeys(useremail);
            form.FindElement(By.CssSelector("input.single-line")).SendKeys(Keys.Tab);
            form.FindElement(By.Id("Password")).SendKeys(userpassword);
            form.FindElement(By.CssSelector("input.login")).Submit();
            return new HomePage(new HtmlPage(Html.Driver));
            


            
        }

      
    }
}
