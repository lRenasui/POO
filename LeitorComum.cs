using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class LeitorComum
    {
        private int idl;
        private string nome;
        private string tempodev;


        public LeitorComum(int idl, string nome, string tempodev)
        {
            this.idl = idl;
            this.nome = nome;

            this.tempodev = tempodev;
        }

        public int getIdl()
        { return idl; }
        public void setIdl(int idl)
        { this.idl = idl; }


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
