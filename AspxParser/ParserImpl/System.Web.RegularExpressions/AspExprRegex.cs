using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>Provides a regular expression to parse an ASP.NET expression block.</summary>
    public class AspExprRegex : Regex
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.AspExprRegex" /> class. </summary>
        public AspExprRegex()
        {
            pattern = "\\G<%\\s*?=(?<code>.*?)?%>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            factory = new AspExprRegexFactory5();
            capnames = new Hashtable();
            capnames.Add("0", 0);
            capnames.Add("code", 1);
            capslist = new string[2];
            capslist[0] = "0";
            capslist[1] = "code";
            capsize = 2;
            InitializeReferences();
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.AspExprRegex" /> class with a specified time-out value.</summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public AspExprRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
