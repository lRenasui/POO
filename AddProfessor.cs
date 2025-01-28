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

    public partial class AddProfessor : Form
    {
        Gestor gestor;
        public AddProfessor(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string nome = textBox2.Text;
            if (id.Trim() != "" && nome.Trim() != "")
            {
                resp = gestor.AddProfessor(Convert.ToInt32(id), nome, 30);
                MessageBox.Show(resp);
                if (resp == "Professor adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
