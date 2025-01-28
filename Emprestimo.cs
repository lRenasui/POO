using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BIBLIOTECA
{
    public class Emprestimo
    {
        private int idEmp;
        private int idL;
        private int idP;
        private string tipolivro;
        private string tipopessoa;
        private string nome;
        private string titulo;
        private DateTime dataEntrga;
        private string entregue;
        public Emprestimo(int idEmp, int idL, int idP, string tipolivro, string tipopessoa, string nome, string titulo, DateTime dataEntrga, string entregue)
        {
            this.idEmp = idEmp;
            this.idL = idL;
            this.idP = idP;
            this.tipolivro = tipolivro;
            this.tipopessoa = tipopessoa;
            this.nome = nome;
            this.titulo = titulo;
            this.dataEntrga = dataEntrga;
            this.entregue = entregue;
        }
        public int getIdEmp()
        { return idEmp; }
        public void setIdEmp(int idEmp)
        { this.idEmp = idEmp; }
        
        public int getIdlivro()
        { return idL; }
        public void setIdlivro(int idL)
        { this.idL = idL; }
        public int getIdPessoa()
        { return idP; }
        public void setIdPassoa(int idP)
        { this.idP = idP; }
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
        public DateTime getData()
        { return dataEntrga; }
        public void setData(DateTime dataEntrga)
        { this.dataEntrga = dataEntrga; }
        public string getEntregue()
        { return entregue; }
        public void setEntregue(string entregue)
        { this.entregue = entregue; }
    }
}
