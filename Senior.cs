using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Senior
    {
        private int ids;
        private string nome;
        private string tempodev;


        public Senior(int ids, string nome, string tempodev)
        {
            this.ids = ids;
            this.nome = nome;
            this.tempodev = tempodev;
        }

        public int getIds()
        { return ids; }
        public void setIds(int ids)
        { this.ids = ids; }


        public string getNome()
        { return nome; }
        public void setNome(string nome)
        { this.nome = nome; }


        public string getTempodev()
        { return tempodev; }
        public void setTempodev(string tempodev)
        { this.tempodev = tempodev; }
    }
}
