using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class GTRegexFactory10 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new GTRegexRunner10();
        }
    }
}