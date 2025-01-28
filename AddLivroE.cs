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
    public partial class AddLivroE : Form
    {
        Gestor gestor;
        public AddLivroE(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string titulo = textBox3.Text;
            string autor = textBox4.Text;
            string anoesc = textBox5.Text;
            string anopub = textBox6.Text;
            string isbn = textBox2.Text;
            if (id.Trim() != "" && titulo.Trim() != "" && autor.Trim() != "" && anoesc.Trim() != "" && anopub.Trim() != "" && isbn.Trim() != "")
            {
                resp = gestor.AddLivroEducativo(Convert.ToInt32(id),titulo,autor,anoesc,anopub,isbn);
                MessageBox.Show(resp);
                if (resp == "Livro Educativo adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }
    }
}
