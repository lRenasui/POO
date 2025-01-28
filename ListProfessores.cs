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
    public partial class ListProfessores : Form

    {
        Gestor gestor;
        public ListProfessores(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (Professor item in gestor.getListaProfessor())
            {

                dataGridView1.Rows.Add(item.getIdp(), item.getNome(), item.getTempodev());
            }
        }
        private void ListProfessores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddProf = new AddProfessor(gestor);
           
            AddProf.Show();
        }
    }
}
