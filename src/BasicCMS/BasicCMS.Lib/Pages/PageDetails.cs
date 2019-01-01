using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCMS.Lib.Pages
{
    public class PageDetails : Page
    {
        public IEnumerable<Page> ChildPages { get; set; }
        public dynamic Content { get; set; }
    }
}
