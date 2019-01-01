using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BasicCMS.Lib.Pages
{
    public class LocalDiskPageProvider : IPageProvider
    {
        private IHostingEnvironment HostingEnvironment;

        public LocalDiskPageProvider(IHostingEnvironment hostingEnvironment)
        {
            HostingEnvironment = hostingEnvironment;
        }

        public Task<bool> ExistsAsync(string url)
        {
            return Task.FromResult(true);
        }

        public async Task<PageDetails> GetAsync(string url)
        {
            var physicalPath = Path.Combine(HostingEnvironment.ContentRootPath, "PageData", (url ?? "index") + ".json");

            var page = JsonConvert.DeserializeObject<PageDetails>(await File.ReadAllTextAsync(physicalPath));
            return page;
            /*
            // test data
            dynamic content = new ExpandoObject();
            content.FilePath = physicalPath;
            return Task.FromResult(new PageDetails()
            {
                Url = url,
                Title = "Test " + url,
                ChildPages = new List<Page>() {
                    new Page() { Url = "test/page1", Title = "Page 1" },
                    new Page() { Url = "test/page2", Title = "Page 2" },
                    new Page() { Url = "test/page3", Title = "Page 3" },
                    new Page() { Url = "test/page4", Title = "Page 4" }

                },
                Content = content
            });
            */
        }

        public Task<IEnumerable<Page>> GetListAsync()
        {
            throw new NotImplementedException();
        }

    }
}
