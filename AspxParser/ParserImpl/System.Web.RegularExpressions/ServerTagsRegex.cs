using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse ASP.NET server tags.
    /// </summary>
    public class ServerTagsRegex : Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.ServerTagsRegex" /> class.
        /// </summary>
        public ServerTagsRegex()
        {
            pattern = "<%(?![#$])(([^%]*)%)*?>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            //factory = new ServerTagsRegexFactory12();
            capsize = 3;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.ServerTagsRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public ServerTagsRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
