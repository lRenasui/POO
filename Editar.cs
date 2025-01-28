using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_BIBLIOTECA
{
    public partial class Editar : Form
    {
        Gestor gestor;
        public Editar(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Livro Educativo")
            {
                comboBox2.Items.Clear();
                foreach (LivroEducativo item in gestor.getListaLivroEducativo())
                {
                    comboBox2.Items.Add(item.getId() + " - " + item.getTitulo());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Livro Cientifico")
            {
                comboBox2.Items.Clear();
                foreach (LivroCientifico item in gestor.getListaLivroCientifico())
                {
                    comboBox2.Items.Add(item.getId() + " - " + item.getTitulo());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Livro Ficção")
            {
                comboBox2.Items.Clear();
                foreach (LivroFiccao item in gestor.getListaLivroFiccao())
                {
                    comboBox2.Items.Add(item.getId() + " - " + item.getTitulo());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Jornal")
            {
                comboBox2.Items.Clear();
                foreach (Jornal item in gestor.getListaJornal())
                {
                    comboBox2.Items.Add(item.getId() + " - " + item.getTitulo());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Revista")
            {
                comboBox2.Items.Clear();
                foreach (Revista item in gestor.getListaRevistas())
                {
                    comboBox2.Items.Add(item.getId() + " - " + item.getTitulo());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Livro Educativo")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Hide();
                label1.Text = "Titulo:";
                label2.Text = "Autor:";
                label3.Text = "Ano de Escolaridade:";
                label4.Text = "Ano de Publicação:";
                label5.Text = "ISBN:";
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Hide();
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                var obj = gestor.getListaLivroEducativo().FirstOrDefault(x => x.getId() == Convert.ToInt32(partsLivro[0]));
                if (obj != null)
                {
                    textBox1.Text = obj.getTitulo();
                    textBox2.Text = obj.getAutor();
                    textBox3.Text = obj.getAnoesc();
                    textBox4.Text = obj.getAnopub();
                    textBox5.Text = obj.getIsbn();
                }


            }
            if (comboBox1.SelectedItem.ToString() == "Livro Cientifico")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Hide();
                label1.Text = "Titulo:";
                label2.Text = "Autor:";
                label3.Text = "Área:";
                label4.Text = "Ano de Publicação:";
                label5.Text = "ISBN:";
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Hide();
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                var obj = gestor.getListaLivroCientifico().FirstOrDefault(x => x.getId() == Convert.ToInt32(partsLivro[0]));
                if (obj != null)
                {
                    textBox1.Text = obj.getTitulo();
                    textBox2.Text = obj.getAutor();
                    textBox3.Text = obj.getArea();
                    textBox4.Text = obj.getAnopub();
                    textBox5.Text = obj.getIsbn();
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Livro Ficção")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Hide();
                label6.Hide();
                label1.Text = "Titulo:";
                label2.Text = "Autor:";
                label3.Text = "Ano de Publicação:";
                label4.Text = "ISBN:";
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Hide();
                textBox6.Hide();
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                var obj = gestor.getListaLivroFiccao().FirstOrDefault(x => x.getId() == Convert.ToInt32(partsLivro[0]));
                if (obj != null)
                {
                    textBox1.Text = obj.getTitulo();
                    textBox2.Text = obj.getAutor();
                    textBox3.Text = obj.getAnopub();
                    textBox4.Text = obj.getIsbn();

                }
            }
            if (comboBox1.SelectedItem.ToString() == "Jornal")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label1.Text = "Titulo:";
                label2.Text = "Autor:";
                label3.Text = "Ano de Publicação:";
                label4.Text = "Edição:";
                label5.Text = "Categoria:";
                label6.Text = "ISSN:";
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                var obj = gestor.getListaJornal().FirstOrDefault(x => x.getId() == Convert.ToInt32(partsLivro[0]));
                if (obj != null)
                {
                    textBox1.Text = obj.getTitulo();
                    textBox2.Text = obj.getAutor();
                    textBox3.Text = obj.getAnopub();
                    textBox4.Text = obj.getEdicao();
                    textBox5.Text = obj.getCategoria();
                    textBox6.Text = obj.getIssn();

                }
            }
            if (comboBox1.SelectedItem.ToString() == "Revista")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Hide();
                label1.Text = "Titulo:";
                label2.Text = "Autor:";
                label3.Text = "Ano de Publicação:";
                label4.Text = "Edição:";
                label5.Text = "ISBN:";
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Hide();
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                var obj = gestor.getListaRevistas().FirstOrDefault(x => x.getId() == Convert.ToInt32(partsLivro[0]));
                if (obj != null)
                {
                    textBox1.Text = obj.getTitulo();
                    textBox2.Text = obj.getAutor();
                    textBox3.Text = obj.getAnopub();
                    textBox4.Text = obj.getEdicao();
                    textBox5.Text = obj.getIsbn();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Livro Educativo")
            {
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                gestor.Editar(Convert.ToInt32(partsLivro[0]), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, "", "", "", textBox5.Text, "", "Livro Educativo");
            }
            if (comboBox1.SelectedItem.ToString() == "Livro Cientifico")
            {
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                gestor.Editar(Convert.ToInt32(partsLivro[0]), textBox1.Text, textBox2.Text,"", textBox4.Text, textBox3.Text, "", "", textBox5.Text, "", "Livro Cientifico");
            }
            if (comboBox1.SelectedItem.ToString() == "Livro Ficção")
            {
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                gestor.Editar(Convert.ToInt32(partsLivro[0]), textBox1.Text, textBox2.Text, "", textBox3.Text, "", "", "", textBox4.Text, "", "Livro Ficção");

            }
            if (comboBox1.SelectedItem.ToString() == "Jornal")
            {
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                gestor.Editar(Convert.ToInt32(partsLivro[0]), textBox1.Text, textBox2.Text, "", textBox3.Text, "", textBox4.Text, textBox5.Text, "", textBox5.Text, "Jornal");

            }
            if (comboBox1.SelectedItem.ToString() == "Revista")
            {
                string[] partsLivro = comboBox2.SelectedItem.ToString().Split(' ');
                gestor.Editar(Convert.ToInt32(partsLivro[0]), textBox1.Text, textBox2.Text, "", textBox3.Text, "", textBox4.Text, "", textBox5.Text, "", "Revista");
            }
        }
    }
}
