using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>Provides a regular expression to parse an ASP.NET comment block.</summary>
    public class CommentRegex : Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.CommentRegex" /> class. 
        /// </summary>
        public CommentRegex()
        {
            pattern = "\\G<%--(([^-]*)-)*?-%>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            factory = new CommentRegexFactory7();
            capsize = 3;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.CommentRegex" /> class with the specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public CommentRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
