using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class EndTagRegexFactory3 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new EndTagRegexRunner3();
        }
    }
}