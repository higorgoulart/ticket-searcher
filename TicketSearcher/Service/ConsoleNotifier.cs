using TicketSearcher.Interface;
using TicketSearcher.Model;

namespace TicketSearcher.Service
{
    public class ConsoleNotifier : INotifier
    {
        public void Notify(IEnumerable<Ticket> tickets)
        {
            Console.Beep(5000, 5000);

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket);
            }

            Console.ResetColor();
        }
    }
}
