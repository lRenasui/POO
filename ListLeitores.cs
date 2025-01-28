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
    public partial class ListLeitores : Form
    {
        Form1 F1 = new Form1();
        Gestor gestor;
        public ListLeitores(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (LeitorComum item in gestor.getListaLeitorComum())
            {

                dataGridView1.Rows.Add(item.getIdl(), item.getNome(), item.getTempodev());
            }
        }
        private void ListLeitores_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = F1.ListaLeitorComum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form AddLeitor = new AddLeitor(gestor);
          
            AddLeitor.Show();
        }
    }
}
