using System.Text;
using System.Text.RegularExpressions;

namespace TicketSearcher.Helper
{
    public static partial class StringExtensions
    {
        public static decimal ToDecimal(this string value)
        {
            var sb = new StringBuilder();

            foreach (var match in OnlyNumbers().Matches(value).Cast<Match>())
            {
                sb.Append(match.Value);
            }

            return decimal.Parse(sb.ToString()) / 100;
        }

        [GeneratedRegex(@"\d+")]
        private static partial Regex OnlyNumbers();
    }
}
