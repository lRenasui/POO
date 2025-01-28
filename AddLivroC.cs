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
    public partial class AddLivroC : Form
    {
        Gestor gestor;
        public AddLivroC(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string titulo = textBox2.Text;
            string autor = textBox3.Text;
            string area = textBox4.Text;
            string anopub = textBox5.Text;
            string isbn = textBox6.Text;
            if (id.Trim() != "" && titulo.Trim() != "" && autor.Trim() != "" && area.Trim() != "" && anopub.Trim() != "" && isbn.Trim() != "")
            {
                resp = gestor.AddLivroCientifico(Convert.ToInt32(id), titulo, autor, area, anopub, isbn);
                MessageBox.Show(resp);
                if (resp == "Livro Cientifico adicionado com sucesso!")
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
