using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class DirectiveRegexFactory2 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new DirectiveRegexRunner2();
        }
    }
}
