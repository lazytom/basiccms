using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicCMS.Lib.Pages
{
    public interface IPageProvider
    {
        Task<bool> ExistsAsync(string url);
        Task<Page> GetAsync(string url);
    }
}
