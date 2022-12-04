using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace busquedaJsonClass
{

    internal class busquedaJson : busquedaJsonBaseVisitor<object>
    {
        public override object VisitArray([NotNull] busquedaJsonParser.ArrayContext context)
        {
            return base.VisitArray(context);
        }

        public override object VisitInput([NotNull] busquedaJsonParser.InputContext context)
        {
            return base.VisitInput(context);
        }

        public override object VisitPrimernumero([NotNull] busquedaJsonParser.PrimernumeroContext context)
        {
            return base.VisitPrimernumero(context);
        }

        public override object VisitProgram([NotNull] busquedaJsonParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override object VisitProperty([NotNull] busquedaJsonParser.PropertyContext context)
        {
            Console.WriteLine(context.GetText());
            List<string> property = new List<string>();
            for(int i = 0; i < context.GetText().Length; i++)
            {
                property.Add(context.GetText());
                Console.WriteLine(property[i]);
            }

            Console.WriteLine("Ingrese la direccion del archivo JSON: ");
            string path = Console.ReadLine();

            StreamReader r = new StreamReader(path);
            string json = r.ReadToEnd();
            //Console.WriteLine(json);
            var jsonDoc = JsonDocument.Parse(json);
            JsonElement elemento = jsonDoc.RootElement.GetProperty(property[0]);
            JsonElement segundo = elemento.GetProperty("city");



            Console.WriteLine($"\n{segundo}");

            return context.GetText();
        }

        public override object VisitSegundonumero([NotNull] busquedaJsonParser.SegundonumeroContext context)
        {
            return base.VisitSegundonumero(context);
        }
    }
}
