using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class LoginPage : UIPage
    {
        public LoginPage(HtmlPage page) :
            base(page)
        {

        }
        

        public Login Login
        {
            get
            {
                return new Login(Html.Descendant(string.Empty));
            }

        }
    }
}
