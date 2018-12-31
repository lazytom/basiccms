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
            return Task.FromResult(new PageDetails()
            {
                Url = url,
                Title = "Test " + url,
                ChildPages = new List<Page>() {
                    new Page() { Url = "test/page1", Title = "Page 1" },
                    new Page() { Url = "test/page2", Title = "Page 2" },
                    new Page() { Url = "test/page3", Title = "Page 3" },
                    new Page() { Url = "test/page4", Title = "Page 4" }

                }
            });
        }

        public Task<IEnumerable<Page>> GetListAsync()
        {
            throw new NotImplementedException();
        }

    }
}
