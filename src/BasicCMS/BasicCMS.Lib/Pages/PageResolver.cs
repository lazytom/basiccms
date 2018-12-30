using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasicCMS.Lib.Pages
{
    public static class PageResolver
    {
        private static List<IPageProvider> Providers = new List<IPageProvider>();

        public static void RegisterPageProvider(IPageProvider provider)
        {
            Providers.Add(provider);
        }

        public static async Task<Page> GetPageAsync(string url)
        {
            return new Page() { Title = "Test " + url };

            return null;
        }
    }
}
