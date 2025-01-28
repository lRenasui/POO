using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Reserva
    {
        private int idReserva;
        private int idlivro;
        private int idpessoa;
        private string tipolivro;
        private string tipopessoa;
        private string nome;
        private string titulo;


        public Reserva(int idReserva, int idlivro, int idpessoa, string tipolivro, string tipopessoa, string nome, string titulo)
        {
            this.idReserva = idReserva;
            this.idlivro = idlivro;
            this.idpessoa = idpessoa;
            this.tipolivro = tipolivro;
            this.tipopessoa = tipopessoa;
            this.nome = nome;
            this.titulo = titulo;
        }

        public int getIdReserva()
        { return idReserva; }
        public void setIdReserva(int idReserva)
        { this.idReserva = idReserva; }
        public int getIdlivro()
        { return idlivro; }
        public void setIdlivro(int idlivro)
        { this.idlivro = idlivro; }
        public int getIdPessoa()
        { return idpessoa; }
        public void setIdPassoa(int idpessoa)
        { this.idpessoa = idpessoa; }
        public string getTipoLivro()
        { return tipolivro; }
        public void setTipoLivro(string tipolivro)
        { this.tipolivro = tipolivro; }
        public string getTipoPessoa()
        { return tipopessoa; }
        public void setTipoPessoa(string tipopessoa)
        { this.tipopessoa = tipopessoa; }
        public string getNome()
        { return nome; }
        public void setNome(string nome)
        { this.nome = nome; }
        public string getTitulo()
        { return titulo; }
        public void setTitulo(string titulo)
        { this.titulo = titulo; }
    }
}
