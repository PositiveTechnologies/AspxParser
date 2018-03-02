using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class IncludeRegexFactory8 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new IncludeRegexRunner8();
        }
    }
}