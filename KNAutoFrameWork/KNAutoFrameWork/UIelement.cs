using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class UIelement
    {
        private HtmlElement _html;
        

        

        protected UIelement(HtmlElement Html)
        {
            this._html = Html;

        }

        public HtmlElement Html
        {
            get
            {
                return _html;
            }
        }

        
            

    }
}
