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
    public partial class AddLeitor : Form

    {
        Gestor gestor;
        public AddLeitor(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nome = textBox2.Text;
            string resp = "";
            if (id.Trim() != "" && nome.Trim() != "")
            {
                resp = gestor.AddLeitor(Convert.ToInt32(id), nome, 7);
                MessageBox.Show(resp);
                if (resp == "Leitor adicionado com sucesso!")
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
