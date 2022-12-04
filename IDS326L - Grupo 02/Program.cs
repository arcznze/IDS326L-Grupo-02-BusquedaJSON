using Antlr4.Runtime;
using busquedaJsonClass;
using Newtonsoft.Json;

namespace BusquedaJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "5*6+9*3-1";
            //Console.WriteLine($"Input: {input}\n");

            //ICharStream stream = CharStreams.fromString(input);
            //busquedaJsonLexer lexer = new busquedaJsonLexer(stream);
            //CommonTokenStream tokens = new CommonTokenStream(lexer);
            //busquedaJsonParser parser = new busquedaJsonParser(tokens);
            //var tree = parser.aritmetica();

            //Aritmetica aritmetica = new Aritmetica();
            //int res = aritmetica.Visit(tree);

            var json = GetJsonFromFile();
            DeserializeJsonFile(json);

            ICharStream stream = CharStreams.fromString(json);

            busquedaJsonLexer lexer = new busquedaJsonLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            busquedaJsonParser parser = new busquedaJsonParser(tokens);
            var tree = parser.program();

            busquedaJson busquedajson = new busquedaJson();
            int res = busquedajson.Visit(tree);

        }
        public static string GetJsonFromFile()
        {

            Console.WriteLine("\nDigite la ubicacion del archivo: ");
            string path = Console.ReadLine();
            
            while(path == "")
            {
                Console.WriteLine("\nDigite una ubicacion valida: ");
                path = Console.ReadLine();
            }

            Console.Clear();


            string json;
            using (var reader = new StreamReader(path))
            {
                json = reader.ReadToEnd();
            }

            return json;
        }

        public static void DeserializeJsonFile(string json)
        {
             Console.WriteLine(json);

        }
    }
}