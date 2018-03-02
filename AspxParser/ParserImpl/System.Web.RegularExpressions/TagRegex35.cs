using System.Collections;
using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse the opening tag of an HTML element, an XML element, or an ASP.NET Web server control tag, for applications that target the .NET Framework 3.5 SP1 and earlier versions.
    /// </summary>
    public class TagRegex35 : Regex
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.TagRegex35" /> class.</summary>
        public TagRegex35()
        {
            pattern = "\\G<(?<tagname>[\\w:\\.]+)(\\s+(?<attrname>\\w[-\\w:]*)(\\s*=\\s*\"(?<attrval>[^\"]*)\"|\\s*=\\s*'(?<attrval>[^']*)'|\\s*=\\s*(?<attrval><%#.*?%>)|\\s*=\\s*(?<attrval>[^\\s=/>]*)|(?<attrval>\\s*?)))*\\s*(?<empty>/)?>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            ////factory = new TagRegex35Factory25();
            capnames = new Hashtable();
            capnames.Add("empty", 6);
            capnames.Add("attrval", 5);
            capnames.Add("tagname", 3);
            capnames.Add("attrname", 4);
            capnames.Add("2", 2);
            capnames.Add("1", 1);
            capnames.Add("0", 0);
            capslist = new string[7];
            capslist[0] = "0";
            capslist[1] = "1";
            capslist[2] = "2";
            capslist[3] = "tagname";
            capslist[4] = "attrname";
            capslist[5] = "attrval";
            capslist[6] = "empty";
            capsize = 7;
            InitializeReferences();
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.TagRegex35" /> class with a specified time-out value.</summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public TagRegex35(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
