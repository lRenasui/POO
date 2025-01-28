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
    public partial class Prorrogar : Form
    {
        Gestor gestor;
        public Prorrogar(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            Encher();

        }
        private void Encher()
        {
            foreach (Emprestimo item in gestor.getListaEmprestimo())
            {
                comboBox1.Items.Add(item.getIdEmp() + " - " + item.getNome() + " - " + item.getTitulo());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] parts;
            parts = comboBox1.SelectedItem.ToString().Split(' ');
            gestor.Prorrogar(Convert.ToInt32(parts[0]));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
