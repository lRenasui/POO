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
    public partial class ListEmprestimos : Form
    {
        Gestor gestor;
        public ListEmprestimos(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        public void PreencherDataGridView()
        {
            foreach (Emprestimo item in gestor.getListaEmprestimo())
            {
                if (item.getEntregue() == "1")
                {

                }
                else
                {
                    dataGridView1.Rows.Add(item.getIdEmp(), item.getNome(), item.getTitulo(), item.getData().ToString("dd/MM/yyyy"));
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form AddEmprestimo = new AddEmprestimo(gestor);

            AddEmprestimo.Show();
        }

        private void ListEmprestimos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form EntregarEmp = new EntregarEmp(gestor);

            EntregarEmp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form Historico = new Historico(gestor);

            Historico.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Prorrogar = new Prorrogar(gestor);

            Prorrogar.Show();
        }
    }
}
