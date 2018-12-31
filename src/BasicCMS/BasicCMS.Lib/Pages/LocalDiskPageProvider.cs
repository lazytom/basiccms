using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicCMS.Lib.Pages
{
    public class LocalDiskPageProvider : IPageProvider
    {
        public Task<bool> ExistsAsync(string url)
        {
            return Task.FromResult(true);
        }

        public Task<Page> GetAsync(string url)
        {
            return Task.FromResult(new Page() { Title = "Test " + url });
        }
    }
}
