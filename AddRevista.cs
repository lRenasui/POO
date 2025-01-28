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
    public partial class AddRevista : Form
    {
        Gestor gestor;
        public AddRevista(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string titulo = textBox2.Text;
            string autor = textBox3.Text;
            string edicao = textBox4.Text;
            string anopub = textBox5.Text;
            string isbn = textBox6.Text;

            string resp = "";
            if (id.Trim() != "" && titulo.Trim() != "" && autor.Trim() != "" && edicao.Trim() != "" && anopub.Trim() != "" && isbn.Trim() != "")
            {
                resp = gestor.AddRevista(Convert.ToInt32(id), titulo, autor, edicao, anopub, isbn);
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
