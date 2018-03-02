using    System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    internal class CommentRegexFactory7 : RegexRunnerFactory
    {
        protected override RegexRunner CreateInstance()
        {
            return new CommentRegexRunner7();
        }
    }
}