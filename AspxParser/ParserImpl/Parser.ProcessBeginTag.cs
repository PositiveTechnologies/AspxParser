using System.Text.RegularExpressions;

namespace AspxParser
{
    partial class Parser
    {
        private void ProcessBeginTag(Match match)
        {
            ProcessLiteral(match.Index);
            string ignored;
            var attributes = ProcessAttributes(match, false, out ignored);
            var name = match.Groups["tagname"].Value;
            var isEmpty = match.Groups["empty"].Success;
            var location = CreateLocation(match);
            if (attributes.IsRunAtServer && "script".EqualsNoCase(name))
            {
                if (!isEmpty)
                {
                    inScriptTag = true;
                    currentScriptTagStart = match.Index + match.Length;
                }
            }

            eventListener.OnTag(location, isEmpty ? TagType.SelfClosing : TagType.Open, string.Intern(name), attributes);
        }
    }
}
