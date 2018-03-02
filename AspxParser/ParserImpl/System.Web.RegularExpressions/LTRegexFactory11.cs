using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class LTRegexFactory11 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new LTRegexRunner11();
        }
    }
}