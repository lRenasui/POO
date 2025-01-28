using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Jornal
    {
        private int id;
        private string titulo;
        private string autor;
        private string anopub;
        private string edicao;
        private string categoria;
        private string issn;
        private string Emprestado;

        public Jornal(int id, string titulo, string autor, string anopub, string edicao, string categoria, string issn, string emprestado)
            
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.anopub = anopub;
            this.edicao = edicao;
            this.categoria = categoria;
            this.issn = issn;
            this.Emprestado = emprestado;
        }

        public int getId()
        { return id; }
        public void setId(int id)
        { this.id = id; }
        public string getEmprestado()
        { return Emprestado; }
        public void setEmprestado(string Emprestado)
        { this.Emprestado = Emprestado; }

        public string getTitulo()
        { return titulo; }
        public void setTitulo(string titulo)
        { this.titulo = titulo; }


        public string getAutor()
        { return autor; }
        public void setAutor(string autor)
        { this.autor = autor; }


        public string getAnopub()
        { return anopub; }
        public void setAnopub(string anopub)
        { this.anopub = anopub; }


        public string getEdicao()
        { return edicao; }
        public void setEdicao(string edicao)
        { this.edicao = edicao; }


        public string getCategoria()
        { return categoria; }
        public void setCategoria(string categoria)
        { this.categoria = categoria; }


        public string getIssn()
        { return issn; }
        public void setIssn(string issn)
        { this.issn = issn; }




        //public override string QuemES() { return "Jornal"; }
    }
}
