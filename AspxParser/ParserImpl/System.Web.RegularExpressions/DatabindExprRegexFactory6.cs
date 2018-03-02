using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class DatabindExprRegexFactory6 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new DatabindExprRegexRunner6();
        }
    }
}