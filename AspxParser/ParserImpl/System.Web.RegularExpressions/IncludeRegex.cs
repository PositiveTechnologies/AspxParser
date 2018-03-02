using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse an ASP.NET <see langword="#include" /> directive.
    /// </summary>
    public class IncludeRegex : Regex
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.IncludeRegex" /> class. </summary>
        public IncludeRegex()
        {
            pattern = "\\G<!--\\s*#(?i:include)\\s*(?<pathtype>[\\w]+)\\s*=\\s*[\"']?(?<filename>[^\\\"']*?)[\"']?\\s*-->";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            //factory = new IncludeRegexFactory8();
            capnames = new Hashtable();
            capnames.Add("pathtype", 1);
            capnames.Add("0", 0);
            capnames.Add("filename", 2);
            capslist = new string[3];
            capslist[0] = "0";
            capslist[1] = "pathtype";
            capslist[2] = "filename";
            capsize = 3;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.IncludeRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public IncludeRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
