using TicketSearcher.Helper;
using TicketSearcher.Interface;
using TicketSearcher.Model;
using OpenQA.Selenium;
using System.Linq.Dynamic.Core;

namespace TicketSearcher.Service
{
    public sealed class TicketSearcherim(string url, WebDriver driver) : ITicketProvider
    {
        public static string Name => "eventim";

        public List<Ticket> SearchBy(string query)
        {
            return GetTickets().AsQueryable()
                .Where(t => t.Available)
                .Where(query).ToList();
        }

        public void Dispose()
        {
            driver.Close();
        }

        private ParallelQuery<Ticket> GetTickets()
        {
            return GetSectors().SelectMany(s => s.Tickets);
        }

        private ParallelQuery<Sector> GetSectors()
        {
            driver.Navigate().GoToUrl(url);

            var ticketPageButton = driver.TryFindElement(By.XPath("//*[@id=\"oneOpenPromoOnlyForm\"]/div/div/button"));

            if (ticketPageButton != null)
                driver.ExecuteScript("arguments[0].click();", ticketPageButton);

            var elements = driver
                .FindElement(By.XPath("//*[@id=\"tickets\"]"))
                .FindElements(By.ClassName("event-list-item"));

            return elements.AsParallel().Select(element =>
            {
                var sectorName = element.FindElement(By.TagName("span")).Text;
                var tickets = element
                    .FindElements(By.ClassName("ticket-type-item"))
                    .Select(element =>
                    {
                        var name = element.FindElement(By.ClassName("ticket-type-title")).FindElement(By.TagName("span")).Text;
                        var price = element.FindElement(By.ClassName("ticket-type-price")).Text.ToDecimal();
                        var stepper = element.FindElementOrNull(By.ClassName("btn-group"));
                        var unavailable = stepper is null || stepper.GetDomAttribute("data-max") == "0";

                        return new Ticket(
                            name,
                            price,
                            !unavailable,
                            sectorName
                        );
                    }).ToArray();

                return new Sector(sectorName, tickets);
            });
        }
    }
}
