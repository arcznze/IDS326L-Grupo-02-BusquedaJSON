using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaJsonClass
{
    
    internal class busquedaJson : busquedaJsonBaseVisitor<string>
    {
        public override string VisitInput([NotNull] busquedaJsonParser.InputContext context)
        {
            context.TEXTO().GetEnumerator().MoveNext();
            context.PUNTO().GetEnumerator().MoveNext();
            context.TEXTO().GetEnumerator().MoveNext();
            context.NUMERO().GetEnumerator().MoveNext();

            return base.VisitInput(context);
        }

        public override string VisitProgram([NotNull] busquedaJsonParser.ProgramContext context)
        {
            Visit(context.input());
            
            return base.VisitProgram(context);
        }
    }
}
