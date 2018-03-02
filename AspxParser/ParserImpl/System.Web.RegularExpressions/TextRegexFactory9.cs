using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class TextRegexFactory9 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new TextRegexRunner9();
        }
    }
}