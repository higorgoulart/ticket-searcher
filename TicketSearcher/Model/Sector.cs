using System.Text;

namespace TicketSearcher.Model;

public class Sector(string name, Ticket[] tickets)
{
    public string Name { get; set; } = name;
    public Ticket[] Tickets { get; set; } = tickets;
}