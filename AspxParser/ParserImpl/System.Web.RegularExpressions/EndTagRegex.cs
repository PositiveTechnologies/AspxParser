using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse an end tag of an HTML element, an XML element, or an ASP.NET web server control tag.
    /// </summary>
    public class EndTagRegex : Regex
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.EndTagRegex" /> class. </summary>
        public EndTagRegex()
        {
            pattern = "\\G</(?<tagname>[\\w:\\.]+)\\s*>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            factory = new EndTagRegexFactory3();
            capnames = new Hashtable();
            capnames.Add("0", 0);
            capnames.Add("tagname", 1);
            capslist = new string[2];
            capslist[0] = "0";
            capslist[1] = "tagname";
            capsize = 2;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.EndTagRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public EndTagRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
