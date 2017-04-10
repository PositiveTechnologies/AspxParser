using System.Text.RegularExpressions;

namespace AspxParser
{
    partial class Parser
    {
        private bool ProcessBeginTag(Match match)
        {
            string ignored;
            var attributes = ProcessAttributes(match, false, out ignored);
            if (!attributes.IsRunAtServer)
            {
                foreach (var pair in attributes)
                {
                    // skip non-server tags with code quotes inside
                    if (pair.Value.Contains("<%") && pair.Value.Contains("%>"))
                    {
                        return false;
                    }
                }
            }

            ProcessLiteral(match.Index);
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
            return true;
        }
    }
}
