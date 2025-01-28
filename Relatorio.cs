using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_BIBLIOTECA
{
    public partial class Relatorio : Form
    {
        Gestor gestor;
        public Relatorio(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            int maxJid, maxRid, maxLCid, maxLEid, maxLFid;

            maxJid = gestor.getListaEstatisticasJ().IndexOf(gestor.getListaEstatisticasJ().Max());
            maxRid = gestor.getListaEstatisticasR().IndexOf(gestor.getListaEstatisticasR().Max());
            maxLCid = gestor.getListaEstatisticasLC().IndexOf(gestor.getListaEstatisticasLC().Max());
            maxLEid = gestor.getListaEstatisticasLE().IndexOf(gestor.getListaEstatisticasLE().Max());
            maxLFid = gestor.getListaEstatisticasLF().IndexOf(gestor.getListaEstatisticasLF().Max());
            if (maxJid == 0)
            {
                label1.Text = "Professores são os que fazem mais Emprestimos de Jornais";
            }
            if (maxJid == 1)
            {
                label1.Text = "Estudantes são os que fazem mais Emprestimos de Jornais";
            }
            if (maxJid == 2)
            {
                label1.Text = "Seniores são os que fazem mais Emprestimos de Jornais";
            }
            if (maxJid == 3)
            {
                label1.Text = "Leitores Comuns são os que fazem mais Emprestimos de Jornais";
            }
            if (maxRid == 0)
            {
                label2.Text = "Professores são os que fazem mais Emprestimos de Revistas";
            }
            if (maxRid == 1)
            {
                label2.Text = "Estudantes são os que fazem mais Emprestimos de Revistas";
            }
            if (maxRid == 2)
            {
                label2.Text = "Seniores são os que fazem mais Emprestimos de Revistas";
            }
            if (maxRid == 3)
            {
                label2.Text = "Leitores Comuns são os que fazem mais Emprestimos de Revistas";
            }

            if (maxLCid == 0)
            {
                label3.Text = "Professores são os que fazem mais Emprestimos de Livros Cientificos";
            }
            if (maxLCid == 1)
            {
                label3.Text = "Estudantes são os que fazem mais Emprestimos de Livros Cientificos";
            }
            if (maxLCid == 2)
            {
                label3.Text = "Seniores são os que fazem mais Emprestimos de Livros Cientificos";
            }
            if (maxLCid == 3)
            {
                label3.Text = "Leitores Comuns são os que fazem mais Emprestimos de Livros Cientificos";
            }

            if (maxLEid == 0)
            {
                label4.Text = "Professores são os que fazem mais Emprestimos de Livros Educativos";
            }
            if (maxLEid == 1)
            {
                label4.Text = "Estudantes são os que fazem mais Emprestimos de Livros Educativos";
            }
            if (maxLEid == 2)
            {
                label4.Text = "Seniores são os que fazem mais Emprestimos de Livros Educativos";
            }
            if (maxLEid == 3)
            {
                label4.Text = "Leitores Comuns são os que fazem mais Emprestimos de Livros Educativos";
            }

            if (maxLFid == 0)
            {
                label5.Text = "Professores são os que fazem mais Emprestimos de Livros de Ficção";
            }
            if (maxLFid == 1)
            {
                label5.Text = "Estudantes são os que fazem mais Emprestimos de Livros de Ficção";
            }
            if (maxLFid == 2)
            {
                label5.Text = "Seniores são os que fazem mais Emprestimos de Livros de Ficção";
            }
            if (maxLFid == 3)
            {
                label5.Text = "Leitores Comuns são os que fazem mais Emprestimos de Livros de Ficção";
            }
        }
    }
}
