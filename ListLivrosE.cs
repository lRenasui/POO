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
    public partial class ListLivrosE : Form
    {
        Gestor gestor;
        public ListLivrosE(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (LivroEducativo item in gestor.getListaLivroEducativo())
            {

                dataGridView1.Rows.Add(item.getId(), item.getTitulo(), item.getAutor(),item.getAnoesc(), item.getAnopub(), item.getIsbn());
            }
        }

        private void ListLivrosE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form AddLivroE = new AddLivroE(gestor);
            
            AddLivroE.Show();
        }
    }
}
