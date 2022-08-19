using Antlr4.Runtime;
using Grammar;
using Interpreter.Lang;

//LEXER
//### input
internal class Program
{
    private static void Main(string[] args)
    {
        var inputStream = new AntlrInputStream("input.lang");
        //### lexer
        var lexer = new LangLexer(inputStream);

        //PARSER
        //### tokens
        var tokenStream = new BufferedTokenStream(lexer);
        //### parser
        var parser = new LangParser(tokenStream);

        //### error listener
        var errorListener = new LangErrorListener();
        parser.ErrorListeners.Clear();
        parser.AddErrorListener(errorListener);

        //### semantic listener
        var semanticListener = new SemanticLangListener();
        parser.ParseListeners.Clear();
        parser.AddParseListener(semanticListener);

        //### error handling
        //parser.ErrorHandler = new BailErrorStrategy();
        parser.ErrorHandler = new DefaultErrorStrategy();

        //### parse
        var tree = parser.prog();
    }
}