using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Professor
    {
        private int idp;
        private string nome;
        private string tempodev;


        public Professor(int idp, string nome, string tempodev)
        {
            this.idp = idp;
            this.nome = nome;
            this.tempodev = tempodev;

        }

        public int getIdp()
        { return idp; }
        public void setIdp(int idp)
        { this.idp = idp; }


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
