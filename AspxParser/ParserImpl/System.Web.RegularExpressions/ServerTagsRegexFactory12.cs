using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class ServerTagsRegexFactory12 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new ServerTagsRegexRunner12();
        }
    }
}