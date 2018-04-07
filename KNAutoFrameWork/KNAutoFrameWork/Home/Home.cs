using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class Home : UIelement
    {
         internal Home(HtmlElement htmlElement) : 
            base(htmlElement)
         {
         }

         

         
             
             public LoginPage  selectLogin()
             {

                 IWebElement el = Html.Element.FindElement(By.CssSelector("a#login"));

                 //el.FindElements
                 //Html.Driver.DrawBorder(el);
                 el.DrawBorder(Html.Driver);
                 el.Click();
                 
                 
              

                 return new LoginPage(new HtmlPage(Html.Driver));
                 
                
             }

             public string getTitle()
             {
                 return Html.Driver.Title.ToString();
             }

        
    }
    
}
