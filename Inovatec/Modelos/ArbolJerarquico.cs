using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inovatec.Modelos
{
    public class ArbolJerarquico
    {
        public NodoJerarquico Raiz { get; set; }

        public ArbolJerarquico(string nombreRaiz)
        {
            Raiz = new NodoJerarquico(nombreRaiz);
        }
    }
}
