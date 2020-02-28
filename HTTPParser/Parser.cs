using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HTTPParser
{
    public class Parser : IParser
    {
        private const string HREF_PATTERN = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";
        private readonly Regex hRefRegex = new Regex(HREF_PATTERN);

        public void Parse(string html)
        {
            foreach (Match match in hRefRegex.Matches(html))
            {
                var value = Regex.Replace(match.ToString(), HREF_PATTERN, @"$1", RegexOptions.IgnoreCase);
                if (IsValide(value))
                {
                    PCController.AddIfValideHTTP(value);
                }
            }
        }

        public bool IsValide(string linq)
        {
            if (linq.Contains("favicon"))
            {
                return false;
            }

            if (linq.Equals("/"))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(linq))
            {
                return false;
            }

            return true;
        }
    }
}
