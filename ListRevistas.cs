using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace POO_BIBLIOTECA
{
    public partial class ListRevistas : Form
    {
        Gestor gestor;
        public ListRevistas(Gestor gestor)
        {
            InitializeComponent();

            this.gestor = gestor;
            PreencherDataGridView();

        }
        private void PreencherDataGridView()
        {
     
            foreach (Revista item in gestor.getListaRevistas())
            {

                dataGridView1.Rows.Add(item.getId(), item.getTitulo(), item.getAutor(), item.getEdicao(), item.getAnopub(), item.getIsbn());
            }
        }
        private void ListRevistas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Form AddRevista = new AddRevista(gestor);
           
            AddRevista.Show();
            
        }
    }
}
