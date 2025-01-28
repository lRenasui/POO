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
    public partial class ListSenior : Form
    {
        Gestor gestor;
        public ListSenior(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (Senior item in gestor.getListaSeniores())
            {

                dataGridView1.Rows.Add(item.getIds(), item.getNome());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddSenior = new AddSenior(gestor);
         
            AddSenior.Show();
        }

        private void ListSenior_Load(object sender, EventArgs e)
        {

        }
    }
}
