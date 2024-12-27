using Microsoft.Extensions.Configuration;
using TicketSearcher.Service;

var settings = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var url = settings["EventUrl"];
var predicate = string.Join(" ", settings["TicketCriteria"]).Replace("'", "\"");

if (url is null || predicate is null)
{
    Console.WriteLine("Pass the correct parameters");
    return;
}

var notifier = new ConsoleNotifier();
using var provider = TicketProviderFactory.GetTicketProvider(url);

while (true)
{
    var tickets = provider.SearchBy(predicate);
    if (tickets.Count > 0)
    {
        notifier.Notify(tickets);
    }
}