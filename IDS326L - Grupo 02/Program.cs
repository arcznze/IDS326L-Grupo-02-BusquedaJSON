using Antlr4.Runtime;
using busquedaJsonClass;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

//static JsonElement SearchElement(JsonElement inicialElement, string[] roadToElement)
//{
//    foreach (JsonProperty element in inicialElement.EnumerateObject())
//    {
//        if (element.Name == roadToElement[0])
//        {
//            if (roadToElement.Length > 1)
//                return SearchElement(element.Value, roadToElement[1..]);
//            else
//                return element.Value;
//        }
//    }

//    throw new Exception($"No se encontró el elemento {roadToElement[0]}");
//}

//static JsonElement GetFirstElement(JsonElement element) => element[0];
//static JsonElement GetLastElement(JsonElement element) => element[-1];
//static JsonElement GetElementPosition(JsonElement element, int index) => element[index];

namespace BusquedaJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var expresion = "menu.popup.menuitem[1]";

            string expression = "";
            Console.WriteLine("Digite su expresion: ");
            do
            {
                expression = Console.ReadLine();
                if(expression == "")
                {
                    Console.WriteLine("\nDigite una expresion valida: ");
                }else if(expression == null)
                {
                    Console.WriteLine("\nNo se permiten expresiones nulas");
                }
            } while (String.IsNullOrEmpty(expression));

                //var inputStream = new AntlrInputStream(expresion);
                //var busquedaJsonLexer = new busquedaJsonLexer(inputStream);
                //var commonTokenStream = new CommonTokenStream(busquedaJsonLexer);
                //var busquedaJsonParser = new busquedaJsonParser(commonTokenStream);
                //var busquedaJsonContext = busquedaJsonParser.program();
                //var visitor = new busquedaJson();
                //visitor.Visit(busquedaJsonContext);

            ICharStream stream = CharStreams.fromString(expression);
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