using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaJsonClass
{
    internal class busquedaJson : busquedaJsonBaseVisitor<int>
    {
        public override int VisitInput([NotNull] busquedaJsonParser.InputContext context)
        {
            Console.WriteLine($"Posicion del elemento: {context.NUMERO()}");
            return base.VisitInput(context);
        }

        public override int VisitProgram([NotNull] busquedaJsonParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }
    }
}
