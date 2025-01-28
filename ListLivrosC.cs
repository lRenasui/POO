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
    public partial class ListLivrosC : Form
    {
        Gestor gestor;
        public ListLivrosC(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (LivroCientifico item in gestor.getListaLivroCientifico())
            {

                dataGridView1.Rows.Add(item.getId(), item.getTitulo(), item.getAutor(), item.getArea(), item.getAnopub(), item.getIsbn());
            }
        }

        private void ListLivrosC_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form AddLivroC = new AddLivroC(gestor);
           
            AddLivroC.Show();
        }
    }
}
