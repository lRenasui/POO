using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Estudante
    {
        private int ide;
        private string nome;
        private string ano;
        private int NLivros;

        public Estudante(int ide, string nome, string ano, int NLivros)
        {
            this.ide = ide;
            this.nome = nome;
            this.ano = ano;
            this.NLivros = NLivros;
 
        }

        public int getIde()
        { return ide; }
        public void setIde(int ide)
        { this.ide = ide; }


        public string getNome()
        { return nome; }
        public void setNome(string nome)
        { this.nome = nome; }


        public string getAno()
        { return ano; }
        public void setAno(string ano)
        { this.ano = ano; }


        public int getNLivros()
        { return NLivros; }
        public void setNLivros(int NLivros)
        { this.NLivros = NLivros; }

    }
}
