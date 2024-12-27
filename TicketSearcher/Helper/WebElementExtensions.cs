using OpenQA.Selenium;

namespace TicketSearcher.Helper
{
    public static class WebElementExtensions
    {
        public static IWebElement? FindElementOrNull(this IWebElement webDriver, By by)
        {
            try
            {
                return webDriver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}
