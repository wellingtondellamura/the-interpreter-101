using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Grammar;
using Interpreter.Lang;

//LEXER
//### input
internal class Program
{
    private static void Main(string[] args)
    {
        var inputStream = new AntlrFileStream("input.lang");
        //### lexer
        var lexer = new LangLexer(inputStream);

        //PARSER
        //### tokens
        var tokenStream = new BufferedTokenStream(lexer);
        //### parser
        var parser = new LangParser(tokenStream);

        //### error listener
        var errorListener = new LangErrorListener();
        parser.RemoveErrorListeners();
        parser.AddErrorListener(errorListener);

        //### semantic listener
        var semanticListener = new SemanticLangListener();
        parser.RemoveParseListeners();
        parser.AddParseListener(semanticListener);

        //### error handling
        //parser.ErrorHandler = new BailErrorStrategy();
        parser.ErrorHandler = new DefaultErrorStrategy();

        //### parse
        IParseTree? tree = null;
        try
        {
            tree = parser.prog();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        //### execute
        if (tree != null)
        {
            var interpreter = new LangInterpreter();
            interpreter.Visit(tree);
        }

    }
}