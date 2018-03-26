using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNAutoFrameWork
{
    public class DatasetViewerPage : UIPage
    {
        public DatasetViewerPage(HtmlPage page) : 
            base(page)
        {


        }

        public DatasetViewer DsViewer
        {
            get
            {
                return new DatasetViewer(Html.Descendant("body"));
            }
        }
    }
}
