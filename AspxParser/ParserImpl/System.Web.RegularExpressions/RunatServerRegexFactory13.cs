using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class RunatServerRegexFactory13 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new RunatServerRegexRunner13();
        }
    }
}
