using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POO_BIBLIOTECA
{
    public partial class AddEmprestimo : Form
    {
        Gestor gestor;
        public AddEmprestimo(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Leitor Comum")
            {
                comboBox2.Items.Clear();
                foreach (LeitorComum item in gestor.getListaLeitorComum())
                {
                    comboBox2.Items.Add(item.getIdl() + " - " + item.getNome());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Senior")
            {
                comboBox2.Items.Clear();
                foreach (Senior item in gestor.getListaSeniores())
                {
                    comboBox2.Items.Add(item.getIds() + " - " + item.getNome());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Estudante")
            {
                comboBox2.Items.Clear();
                foreach (Estudante item in gestor.getListaEstudantes())
                {
                    comboBox2.Items.Add(item.getIde() + " - " + item.getNome());
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Professor")
            {
                comboBox2.Items.Clear();
                foreach (Professor item in gestor.getListaProfessor())
                {
                    comboBox2.Items.Add(item.getIdp() + " - " + item.getNome());
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedItem.ToString() == "Revistas")
            {
                comboBox4.Items.Clear();
                foreach (Revista item in gestor.getListaRevistas())
                {
                    if (item.getEmprestado() == "0")
                    {
                        comboBox4.Items.Add(item.getId() + " - " + item.getTitulo() + " - " + item.getEdicao());
                    }
                    }
            }
            if (comboBox3.SelectedItem.ToString() == "Jornais")
            {
                comboBox4.Items.Clear();
                foreach (Jornal item in gestor.getListaJornal())
                {
                    if (item.getEmprestado() == "0")
                    {
                        comboBox4.Items.Add(item.getId() + " - " + item.getTitulo() + " - " + item.getEdicao());
                    }
                    }
            }
            if (comboBox3.SelectedItem.ToString() == "Livros Cientificos")
            {
                comboBox4.Items.Clear();
                foreach (LivroCientifico item in gestor.getListaLivroCientifico())
                {
                    if (item.getEmprestado() == "0")
                    {
                        comboBox4.Items.Add(item.getId() + " - " + item.getTitulo());
                    }
                }
            }
            if (comboBox3.SelectedItem.ToString() == "Livros Educativos")
            {
                comboBox4.Items.Clear();
                foreach (LivroEducativo item in gestor.getListaLivroEducativo())
                {
                    if (item.getEmprestado() == "0")
                    {
                        comboBox4.Items.Add(item.getId() + " - " + item.getTitulo());
                    }
                }
            }
            if (comboBox3.SelectedItem.ToString() == "Livros de Ficção")
            {
                comboBox4.Items.Clear();
                foreach (LivroFiccao item in gestor.getListaLivroFiccao())
                {
                    if (item.getEmprestado() == "0")
                    {
                        comboBox4.Items.Add(item.getId() + " - " + item.getTitulo());
                    }
                    
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataentrga = DateTime.Today;
            string id, idEmp, nome, tipoP = "tipo", idL, titulo, tipoL = "tipo";
            string itemPessoa = "";
            string[] partsPessoa;
            string itemLivro = "";
            string[] partsLivro;
            string resp = "";
            itemPessoa = comboBox2.SelectedItem.ToString();
            partsPessoa = itemPessoa.Split(" - ");
            itemLivro = comboBox4.SelectedItem.ToString();
            partsLivro = itemLivro.Split(' ');
            tipoP = comboBox1.SelectedItem.ToString();
            id = partsPessoa[0];
            nome = partsPessoa[1];
            idL = partsLivro[0];
            idEmp = textBox1.Text;
            titulo = partsLivro[2];
            if (comboBox3.SelectedItem.ToString() == "Revistas")
            {
                tipoL = "Revista";
            }
            if (comboBox3.SelectedItem.ToString() == "Jornais")
            {
                tipoL = "Jornal";
            }
            if (comboBox3.SelectedItem.ToString() == "Livros Cientificos")
            {
                tipoL = "Livro Cientifico";
            }
            if (comboBox3.SelectedItem.ToString() == "Livros Educativos")
            {
                tipoL = "Livro Educativo";
            }
            if (comboBox3.SelectedItem.ToString() == "Livros de Ficção")
            {
                tipoL = "Livro Ficção";
            }
            if ((tipoP == "Estudante") && (tipoL == "Livro Educativo"))
            {
                dataentrga = DateTime.Today.AddDays(gestor.getNDiasEstu());
            }
            if ((tipoP == "Professor") && (tipoL == "Livro Cientifico"))
            {
                dataentrga = DateTime.Today.AddDays(gestor.getNDiasProf());
            }
            else
            {
                dataentrga = DateTime.Today.AddDays(gestor.getNdDiasResto());
            }
            if (id.Trim() != "" && nome.Trim() != ""
                && tipoP.Trim() != "" && idL.Trim() != "" && titulo.Trim() != ""
                && tipoL.Trim() != "" && idEmp.Trim() != "" && dataentrga.ToString().Trim() != "")
            {
                resp = gestor.AddEmprestimo(Convert.ToInt32(idEmp), Convert.ToInt32(idL), Convert.ToInt32(id), tipoL, tipoP, titulo, nome, dataentrga);
                MessageBox.Show(resp);
                if (resp == "Emprestimo adicionado com sucesso!")
                {
                    textBox1.Clear();
                    
                }

            }
            else
                MessageBox.Show("Preencha os dados em falta");

        }

        private void AddEmprestimo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
