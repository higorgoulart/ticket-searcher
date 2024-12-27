using System.Text;

namespace TicketSearcher.Model
{
    public class Ticket(string name, decimal price, bool available, string sectorName)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public bool Available { get; set; } = available;
        public string SectorName { get; set; } = sectorName;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("-----");
            sb.AppendLine(Name);
            sb.AppendLine(Price.ToString());
            sb.AppendLine(Available ? "AVAILABLE" : "UNAVAILABLE");

            return sb.ToString();
        }
    }
}
