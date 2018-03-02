using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspCodeRegexFactory4 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new AspCodeRegexRunner4();
        }
    }
}