using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicCMS.Lib.Pages
{
    public interface IPageProvider
    {
        Task<IEnumerable<Page>> GetListAsync();
        Task<bool> ExistsAsync(string url);
        Task<PageDetails> GetAsync(string url);
    }
}
