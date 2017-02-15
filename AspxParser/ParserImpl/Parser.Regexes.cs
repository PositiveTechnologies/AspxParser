using System.Text.RegularExpressions;
using System.Web.RegularExpressions;

namespace AspxParser
{
    partial class Parser
    {
        private readonly Regex tagRegex;
        private static readonly Regex tagRegex35 = new TagRegex35();
        private static readonly Regex tagRegex40 = new TagRegex();
        private static readonly Regex directiveRegex = new DirectiveRegex();
        private static readonly Regex endtagRegex = new EndTagRegex();
        private static readonly Regex aspCodeRegex = new AspCodeRegex();
        private static readonly Regex aspExprRegex = new AspExprRegex();
        private static readonly Regex aspEncodedExprRegex = new AspEncodedExprRegex();
        private static readonly Regex databindExprRegex = new DatabindExprRegex();
        private static readonly Regex commentRegex = new CommentRegex();
        private static readonly Regex includeRegex = new IncludeRegex();
        private static readonly Regex textRegex = new TextRegex();
        private static readonly Regex gtRegex = new GTRegex();
        private static readonly Regex ltRegex = new LTRegex();
        private static readonly Regex serverTagsRegex = new ServerTagsRegex();
        private static readonly Regex runatServerRegex = new RunatServerRegex();
    }
}
