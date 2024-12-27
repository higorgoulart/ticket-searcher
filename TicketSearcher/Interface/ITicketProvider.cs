using TicketSearcher.Model;

namespace TicketSearcher.Interface
{
    public interface ITicketProvider : IDisposable
    {
        List<Ticket> SearchBy(string query);
    }
}
