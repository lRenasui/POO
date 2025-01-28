using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_BIBLIOTECA
{
    public partial class ListEstudantes : Form
    {
        Gestor gestor;
        public ListEstudantes(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (Estudante item in gestor.getListaEstudantes())
            {

                dataGridView1.Rows.Add(item.getIde(), item.getNome(), item.getAno(),item.getNLivros());
            }
        }
        private void ListEstudantes_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Form AddEstudante = new AddEstudante(gestor);
         
            AddEstudante.Show();
        }
    }
}
