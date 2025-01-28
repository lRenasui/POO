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
    public partial class AddSenior : Form
    {
        Gestor gestor;
        public AddSenior(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string nome = textBox2.Text;
            if (id.Trim() != "" && nome.Trim() != "")
            {
                resp = gestor.AddSenior(Convert.ToInt32(id), nome, 7);
                MessageBox.Show(resp);
                if (resp == "Senior adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }
    }
}
