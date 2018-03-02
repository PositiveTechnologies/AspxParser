using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to match a greater than (&gt;) character in an ASP.NET web page.
    /// </summary>
    public class GTRegex : Regex
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.GTRegex" /> class. </summary>
        public GTRegex()
        {
            pattern = "[^%]>";
            roptions = RegexOptions.Multiline | RegexOptions.Singleline;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            factory = new GTRegexFactory10();
            capsize = 1;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.GTRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public GTRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
