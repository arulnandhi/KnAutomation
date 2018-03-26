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
                 Html.Element.FindElement(By.CssSelector("a#login")).Click();

                 return new LoginPage(new HtmlPage(Html.Driver));
                 
                
             }

             public string getTitle()
             {
                 return Html.Driver.Title.ToString();
             }

        
    }
    
}
