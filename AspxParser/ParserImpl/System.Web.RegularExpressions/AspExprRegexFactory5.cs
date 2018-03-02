using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspExprRegexFactory5 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new AspExprRegexRunner5();
        }
    }
}
