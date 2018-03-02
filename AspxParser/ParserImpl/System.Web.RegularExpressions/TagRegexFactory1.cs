using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class TagRegexFactory1 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new TagRegexRunner1();
        }
    }
}