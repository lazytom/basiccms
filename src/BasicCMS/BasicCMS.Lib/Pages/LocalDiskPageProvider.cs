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

        public Task<PageDetails> GetAsync(string url)
        {
            return Task.FromResult(new PageDetails() { Title = "Test " + url });
        }

        public Task<IEnumerable<Page>> GetListAsync()
        {
            throw new NotImplementedException();
        }

    }
}
