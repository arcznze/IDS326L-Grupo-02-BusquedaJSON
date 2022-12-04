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
            //var expresion = "menu.popup.menuitem[1]";

            Console.WriteLine("Digite su expresion: ");
            string expresion = Console.ReadLine();

            //var inputStream = new AntlrInputStream(expresion);
            //var busquedaJsonLexer = new busquedaJsonLexer(inputStream);
            //var commonTokenStream = new CommonTokenStream(busquedaJsonLexer);
            //var busquedaJsonParser = new busquedaJsonParser(commonTokenStream);
            //var busquedaJsonContext = busquedaJsonParser.program();
            //var visitor = new busquedaJson();
            //visitor.Visit(busquedaJsonContext);

            ICharStream stream = CharStreams.fromString(expresion);
            busquedaJsonLexer lexer = new busquedaJsonLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            busquedaJsonParser parser = new busquedaJsonParser(tokens);
            var tree = parser.program();

            busquedaJson jsonSearch = new busquedaJson();
            string resultado = (string)jsonSearch.Visit(tree);
            Console.WriteLine(resultado);

            //GetJson(expresion);

            //Console.WriteLine("Ingrese la direccion del archivo JSON: ");
            //string path = Console.ReadLine();

            //StreamReader r = new StreamReader(path);
            //string json = r.ReadToEnd();
            //Console.WriteLine(json);
            //var jsonDoc = JsonDocument.Parse(json);
            //JsonElement elemento = jsonDoc.RootElement.GetProperty(resultado);
            //Console.WriteLine($"Elemento = {elemento}");

        }

        //public static string GetJson(string expresion)
        //{
        //    Console.WriteLine("\nDigite la ubicacion del archivo: ");
        //    string path = Console.ReadLine();

        //    while (path == "")
        //    {
        //        Console.WriteLine("\nDigite una ubicacion valida: ");
        //        path = Console.ReadLine();
        //    }

        //    Console.Clear();

        //    string json;
        //    using (var reader = new StreamReader(path))
        //    {
        //        json = reader.ReadToEnd();
        //    }

        //    JsonNode jsonNode = JsonNode.Parse(json)!;

        //    var options = new JsonSerializerOptions { WriteIndented = true };
        //    var res = jsonNode!.ToJsonString(options);

        //    JsonNode resultado = jsonNode![expresion]!;
        //    Console.WriteLine($"JSON={resultado.ToJsonString()}");

        //    //JsonNode document = JsonNode.Parse(json)!;

        //    //JsonNode root = document.Root;




        //    return "";
        //}

        //public static void LoadJson()
        //{
        //    Console.WriteLine("Ingrese la direccion del archivo JSON: ");
        //    string path = Console.ReadLine();
        //    Console.WriteLine("Ingrese el elemento que desea ver del JSON: ");
        //    string elmnt = Console.ReadLine();

        //    using (StreamReader r = new StreamReader(path))
        //    {
        //        string json = r.ReadToEnd();
        //        Console.WriteLine(json);

        //        using (var jsonDoc = JsonDocument.Parse(json))
        //        {
        //            JsonElement elemento = jsonDoc.RootElement.GetProperty(res);
        //            Console.WriteLine($"Elemento = {res}");
        //        }

        //    }
    }
}