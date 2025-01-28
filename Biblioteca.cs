using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    internal class Biblioteca
    {
        //List<Geral> L_Livros;
        //Dictionary<string, List<Geral>> L_LivrosDict;
        //List<Leitor> L_Leitores;
        string NOME;

        public Biblioteca(string _nome)
        {
            NOME = _nome;
        }
        public bool LerFicheiro(string nficheiro)
        {
            return true;
        }
        public bool GravarFicheiro(string nficheiro)
        {
            return true;
        }
        public void Add(Geral X)
        {

        }
        public void Add(Leitor X)
        {

        }
    }
}
