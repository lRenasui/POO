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
    public partial class AddJornal : Form
    {
        Gestor gestor;
        public AddJornal(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resp = "";
            string id = textBox1.Text;
            string titulo = textBox2.Text;
            string autor = textBox3.Text;
            string edicao = textBox4.Text;
            string categoria = textBox5.Text;
            string anopub = textBox6.Text;
            string issn = textBox7.Text;
            if (id.Trim() != "" && titulo.Trim() != ""
                && autor.Trim() != "" && edicao.Trim() != "" && categoria.Trim() != ""
                && anopub.Trim() != "" && issn.Trim() != "")
            {
                resp = gestor.AddJornal(Convert.ToInt32(id), titulo, autor, anopub,edicao,categoria,issn);
                MessageBox.Show(resp);
                if (resp == "Jornal adicionado com sucesso!")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();

                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");
        }
    }



}
