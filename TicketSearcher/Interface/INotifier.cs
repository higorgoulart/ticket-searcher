using TicketSearcher.Model;

namespace TicketSearcher.Interface
{
    public interface INotifier
    {
        public void Notify(IEnumerable<Ticket> tickets);
    }
}
