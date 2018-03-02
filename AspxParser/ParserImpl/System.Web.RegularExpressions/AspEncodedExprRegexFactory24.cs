using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class AspEncodedExprRegexFactory24 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new AspEncodedExprRegexRunner24();
        }
    }
}