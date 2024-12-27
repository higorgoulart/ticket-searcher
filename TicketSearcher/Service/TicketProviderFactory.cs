using TicketSearcher.Interface;
using OpenQA.Selenium.Chrome;

namespace TicketSearcher.Service
{
    public static class TicketProviderFactory
    {
        public static ITicketProvider GetTicketProvider(string url)
        {
            var driver = new ChromeDriver();

            if (url.Contains(TicketSearcherim.Name))
                return new TicketSearcherim(url, driver);

            throw new NotImplementedException();
        }
    }
}
