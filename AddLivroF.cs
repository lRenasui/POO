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
    public partial class AddLivroF : Form
    {
        Gestor gestor;
        public AddLivroF(Gestor gestor)
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
            string anopub = textBox4.Text;
            string isbn = textBox5.Text;
            if (id.Trim() != "" && titulo.Trim() != "" && autor.Trim() != "" && anopub.Trim() != "" && isbn.Trim() != "")
            {
                resp = gestor.AddLivroFiccao(Convert.ToInt32(id), titulo, autor, anopub, isbn);
                MessageBox.Show(resp);
                if (resp == "Livro de Ficção adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }
    }
}
