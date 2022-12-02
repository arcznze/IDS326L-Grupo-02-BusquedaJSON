using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaJsonClass
{
    internal class busquedaJson : busquedaJsonBaseVisitor<object>
    {
        public override object VisitArray([NotNull] busquedaJsonParser.ArrayContext context)
        {
            return base.VisitArray(context);
        }

        public override object VisitDatos([NotNull] busquedaJsonParser.DatosContext context)
        {
            return base.VisitDatos(context);
        }

        public override object VisitJson([NotNull] busquedaJsonParser.JsonContext context)
        {
            return base.VisitJson(context);
        }

        public override object VisitObjeto([NotNull] busquedaJsonParser.ObjetoContext context)
        {
            return base.VisitObjeto(context);
        }

        public override object VisitValor([NotNull] busquedaJsonParser.ValorContext context)
        {
            return base.VisitValor(context);
        }
    }
}
