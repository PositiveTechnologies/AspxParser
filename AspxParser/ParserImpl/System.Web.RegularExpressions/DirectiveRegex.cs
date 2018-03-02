using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse an ASP.NET directive.
    /// </summary>
    public class DirectiveRegex : Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.DirectiveRegex" /> class. 
        /// </summary>
        public DirectiveRegex()
        {
            pattern = "\\G<%\\s*@(\\s*(?<attrname>\\w[\\w:]*(?=\\W))(\\s*(?<equal>=)\\s*\"(?<attrval>[^\"]*)\"|\\s*(?<equal>=)\\s*'(?<attrval>[^']*)'|\\s*(?<equal>=)\\s*(?<attrval>[^\\s\"'%>]*)|(?<equal>)(?<attrval>\\s*?)))*\\s*?%>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            ////factory = new DirectiveRegexFactory2();
            capnames = new Hashtable();
            capnames.Add("1", 1);
            capnames.Add("attrval", 5);
            capnames.Add("equal", 4);
            capnames.Add("attrname", 3);
            capnames.Add("2", 2);
            capnames.Add("0", 0);
            capslist = new string[6];
            capslist[0] = "0";
            capslist[1] = "1";
            capslist[2] = "2";
            capslist[3] = "attrname";
            capslist[4] = "equal";
            capslist[5] = "attrval";
            capsize = 6;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.DirectiveRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public DirectiveRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
