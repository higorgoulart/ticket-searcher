using OpenQA.Selenium;

namespace TicketSearcher.Helper;

public static class WebDriverExtensions
{
    public static IWebElement? TryFindElement(this IWebDriver webDriver, By by, int maxTries = 3)
    {
        var tries = 0;

        IWebElement? element;
        do
        {
            element = webDriver.FindElementOrNull(by);
            tries++;
        }
        while (element is null && tries < maxTries);

        return element;
    }

    public static IWebElement? FindElementOrNull(this IWebDriver webDriver, By by)
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