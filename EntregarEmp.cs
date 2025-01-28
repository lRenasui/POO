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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POO_BIBLIOTECA
{
    public partial class EntregarEmp : Form
    {
        Gestor gestor;
        public EntregarEmp(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string[] parts;
            parts = comboBox1.SelectedItem.ToString().Split(' ');
            string id;
            id = parts[0];
            resp = gestor.AcabarEmprestimo(Convert.ToInt32(id));
            MessageBox.Show(resp);
        }

        private void EntregarEmp_Load(object sender, EventArgs e)
        {
            foreach (Emprestimo item in gestor.getListaEmprestimo())
            {
                comboBox1.Items.Add(item.getIdEmp() + " | " + item.getTitulo() + " - " + item.getNome() + " | " + item.getData().ToString("dd/MM/yyyy"));
            }
        }
    }
}
