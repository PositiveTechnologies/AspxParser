Aspx files (aspx, cshtml, etc.) parser based on regex.

## Usage

### Source Code Parsing

Use `AspxParser`:

```CSharp
var parser = new AspxParser(rootDirectory);
var source = new AspxSource(fileName, fileCode);
AspxParseResult aspxTree = parser.Parse(source);
```

Result `AspxParseResult` contains a reference to a parse tree `RootNode` and to a list with parse errors `ParserErrors`.

### Parse Tree Bypass

Use `DepthFirstAspxVisitor` or `DepthFirstAspxWithoutCloseTagVisitor` visitors:

```CSharp
public AspxToCsConverter : DepthFirstAspxWithoutCloseTagVisitor<string>
{
    public override string Visit(AspxNode.Root node)
    {
        ...
    }

    public override string Visit(AspxNode.HtmlTag node)
    {
        ...
    }
}

var converter = new AspxToCsConverter();
var result = aspxTree.Root.Accept(converter);
```

## Licence

AspxParser is licensed under the MIT License.