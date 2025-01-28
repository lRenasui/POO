using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Revista
    {
        private int id;
        private string titulo;
        private string autor;
        private string edicao;
        private string anopub;
        private string isbn;
        private string Emprestado;
        public Revista(int id, string titulo, string autor, string edicao, string anopub, string isbn, string emprestado)
            
        {
            this.id = id;
            this.titulo = titulo;
            this.autor = autor;
            this.edicao = edicao;
            this.anopub = anopub;
            this.isbn = isbn;
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


        public string getEdicao()
        { return edicao; }
        public void setEdicao(string edicao)
        { this.edicao = edicao; }


        public string getAnopub()
        { return anopub; }
        public void setAnopub(string anopub)
        { this.anopub = anopub; }


        public string getIsbn()
        { return isbn; }
        public void setIsbn(string isbn)
        { this.isbn = isbn; }




       
    }
}
