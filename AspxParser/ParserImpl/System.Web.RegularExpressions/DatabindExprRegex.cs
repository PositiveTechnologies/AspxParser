using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse an ASP.NET data-binding expression.
    /// </summary>
    public class DatabindExprRegex : Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.DatabindExprRegex" /> class. 
        /// </summary>
        public DatabindExprRegex()
        {
            pattern = "\\G<%#(?<encode>:)?(?<code>.*?)?%>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            //factory = new DatabindExprRegexFactory6();
            capnames = new Hashtable();
            capnames.Add("0", 0);
            capnames.Add("code", 2);
            capnames.Add("encode", 1);
            capslist = new string[3];
            capslist[0] = "0";
            capslist[1] = "encode";
            capslist[2] = "code";
            capsize = 3;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.DatabindExprRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public DatabindExprRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
