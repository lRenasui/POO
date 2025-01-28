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
    public partial class ListLivrosF : Form
    {
        Gestor gestor;
        public ListLivrosF(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (LivroFiccao item in gestor.getListaLivroFiccao())
            {

                dataGridView1.Rows.Add(item.getId(), item.getTitulo(), item.getAutor(), item.getAnopub(), item.getIsbn());
            }
        }

        private void ListLivrosF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form AddLivroF = new AddLivroF(gestor);
          
            AddLivroF.Show();
        }
    }
}
