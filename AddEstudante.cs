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
    public partial class AddEstudante : Form
    {
        Gestor gestor;
        public AddEstudante(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string nome = textBox2.Text;
            string ano = textBox3.Text;
            if (id.Trim() != "" && nome.Trim() != "" && ano.Trim() != "")
            {
                resp = gestor.AddEstudante(Convert.ToInt32(id), nome,ano);
                MessageBox.Show(resp);
                if (resp == "Estudante adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }
    }
}
