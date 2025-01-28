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
    public partial class ListJornais : Form
    {
        Gestor gestor;
        public ListJornais(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {
            foreach (Jornal item in gestor.getListaJornal())
            {
                dataGridView1.Rows.Add(item.getId(), item.getTitulo(), item.getAutor(), item.getEdicao(), item.getCategoria(), item.getAnopub(), item.getIssn());

            }
        }

        private void ListJornais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form AddJornal = new AddJornal(gestor);
          
            AddJornal.Show();
        }
    }
}
