using Antlr4.Runtime;
using busquedaJsonClass;

string input = "5*6+9*3-1";
Console.WriteLine($"Input: {input}\n");

ICharStream stream = CharStreams.fromString(input);
busquedaJsonLexer lexer = new busquedaJsonLexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
busquedaJsonParser parser = new busquedaJsonParser(tokens);
var tree = parser.aritmetica();

Aritmetica aritmetica = new Aritmetica();
int res = aritmetica.Visit(tree);