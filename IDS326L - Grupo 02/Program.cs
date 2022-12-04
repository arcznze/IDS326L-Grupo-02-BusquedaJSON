using Antlr4.Runtime;
using busquedaJsonClass;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace BusquedaJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var expresion = "menu.popup.menuitem[1]";

            Console.WriteLine("Digite su expresion: ");
            expresion = Console.ReadLine();

            var inputStream = new AntlrInputStream(expresion);
            var busquedaJsonLexer = new busquedaJsonLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(busquedaJsonLexer);
            var busquedaJsonParser = new busquedaJsonParser(commonTokenStream);
            var busquedaJsonContext = busquedaJsonParser.program();
            var visitor = new busquedaJson();
            visitor.Visit(busquedaJsonContext);

            GetJson(expresion);
        }
        public static string GetJson(string expresion)
        {
            Console.WriteLine("\nDigite la ubicacion del archivo: ");
            string path = Console.ReadLine();


            Console.Clear();

            string json;
            using (var reader = new StreamReader(path))
            {
                json = reader.ReadToEnd();
            }

            JsonNode jsonNode = JsonNode.Parse(json)!;

            var options = new JsonSerializerOptions { WriteIndented = true };
            var res = jsonNode!.ToJsonString(options);

            JsonNode resultado = jsonNode![expresion]!;
            Console.WriteLine($"JSON={resultado.ToJsonString()}");

            //JsonNode document = JsonNode.Parse(json)!;

            //JsonNode root = document.Root;




            return "";
        }
      
    }
}