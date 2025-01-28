using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_BIBLIOTECA
{
    public class Multa
    {
        private int idmulta;
        private int id;
        private string nome;
        private string tipoP;
        private int valor;
        public Multa(int idmulta, int id, string nome, string tipoP, int valor)
        {
            this.id = id;
            this.idmulta = idmulta;
            this.nome = nome;
            this.valor = valor;
            this.tipoP = tipoP;
        }
        public int getIdMulta()
        { return idmulta; }
        public void setIdMulta(int idmulta)
        { this.idmulta = idmulta; }
        public int getId()
        { return id; }
        public void setId(int id)
        { this.id = id; }

        public string getNome()
        { return nome; }
        public void setNome(string nome)
        { this.nome = nome; }
        public string getTipo()
        { return tipoP; }
        public void setTipo(string tipoP)
        { this.tipoP = tipoP; }

        public int getValor()
        { return valor; }
        public void setValor(int valor)
        { this.valor = valor; }
    }
}
