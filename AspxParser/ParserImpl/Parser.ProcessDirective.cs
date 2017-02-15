using System.Text.RegularExpressions;

namespace AspxParser
{
    partial class Parser
    {
        private void ProcessDirective(Match match)
        {
            ProcessLiteral(match.Index);

            string directiveName;
            var attributes = ProcessAttributes(match, true, out directiveName);

            var location = CreateLocation(match);
            eventListener.OnDirective(location, directiveName, attributes);

            ignoreNextSpaceString = true;
        }
    }
}
