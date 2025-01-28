using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Geral
    {
        DateTime DATA;
        string TITULO;

        public Geral(DateTime _data, string _titulo)
        {
            DATA = _data;
            TITULO = _titulo;
        }   
        public virtual string QuemES() { return "GERAL"; }
    }
}
