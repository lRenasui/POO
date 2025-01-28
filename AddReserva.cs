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
    public partial class AddReserva : Form
    {
        Gestor gestor;
        public AddReserva(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedItem.ToString() == "Leitor Comum")
            {
                comboBox7.Items.Clear();

                foreach (LeitorComum item in gestor.getListaLeitorComum())
                {
                    comboBox7.Items.Add(item.getIdl() + " - " + item.getNome());
                }
            }
            if (comboBox8.SelectedItem.ToString() == "Senior")
            {
                comboBox7.Items.Clear();
                foreach (Senior item in gestor.getListaSeniores())
                {
                    comboBox7.Items.Add(item.getIds() + " - " + item.getNome());
                }
            }
            if (comboBox8.SelectedItem.ToString() == "Estudante")
            {
                comboBox7.Items.Clear();
                foreach (Estudante item in gestor.getListaEstudantes())
                {
                    comboBox7.Items.Add(item.getIde() + " - " + item.getNome());
                }
            }
            if (comboBox8.SelectedItem.ToString() == "Professor")
            {
                comboBox7.Items.Clear();
                foreach (Professor item in gestor.getListaProfessor())
                {
                    comboBox7.Items.Add(item.getIdp() + " - " + item.getNome());
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem.ToString() == "Revistas")
            {
                comboBox5.Items.Clear();
                foreach (Emprestimo item1 in gestor.getListaEmprestimo())
                {
                    if (item1.getTipoLivro() == "Revista")
                    {
                        comboBox5.Items.Add(item1.getIdlivro() + " - " + item1.getTitulo());
                    }
                }
            }
            if (comboBox6.SelectedItem.ToString() == "Jornais")
            {
                comboBox5.Items.Clear();
                
                    foreach (Emprestimo item1 in gestor.getListaEmprestimo())
                    {
                        if (item1.getTipoLivro() == "Jornal")
                        {
                            comboBox5.Items.Add(item1.getIdlivro() + " - " + item1.getTitulo());
                        }
                    }

                
            }
            if (comboBox6.SelectedItem.ToString() == "Livros Cientificos")
            {
                comboBox5.Items.Clear();
                foreach (Emprestimo item1 in gestor.getListaEmprestimo())
                {
                    if (item1.getTipoLivro() == "Livro Cientifico")
                    {
                        comboBox5.Items.Add(item1.getIdlivro() + " - " + item1.getTitulo());
                    }
                }
            }
            if (comboBox6.SelectedItem.ToString() == "Livros Educativos")
            {
                comboBox5.Items.Clear();
                foreach (Emprestimo item1 in gestor.getListaEmprestimo())
                {
                    if (item1.getTipoLivro() == "Livro Educativo")
                    {
                        comboBox5.Items.Add(item1.getIdlivro() + " - " + item1.getTitulo());
                    }
                }
            }
            if (comboBox6.SelectedItem.ToString() == "Livros de Ficção")
            {
                comboBox5.Items.Clear();
                foreach (Emprestimo item1 in gestor.getListaEmprestimo())
                {
                    if (item1.getTipoLivro() == "Livro Ficção")
                    {
                        comboBox5.Items.Add(item1.getIdlivro() + " - " + item1.getTitulo());
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, idR, nome, tipoP = "tipo", idL, titulo, tipoL = "tipo";
            string itemPessoa = "";
            string[] partsPessoa;
            string itemLivro = "";
            string[] partsLivro;
            string resp = "";
            itemPessoa = comboBox7.SelectedItem.ToString();
            partsPessoa = itemPessoa.Split(" - ");
            itemLivro = comboBox5.SelectedItem.ToString();
            partsLivro = itemLivro.Split(' ');
            tipoP = comboBox8.SelectedItem.ToString();
            id = partsPessoa[0];
            nome = partsPessoa[1];
            idL = partsLivro[0];
            idR = textBox1.Text;
            titulo = partsLivro[2];
            if (comboBox6.SelectedItem.ToString() == "Revistas")
            {
                tipoL = "Revista";
            }
            if (comboBox6.SelectedItem.ToString() == "Jornais")
            {
                tipoL = "Jornal";
            }
            if (comboBox6.SelectedItem.ToString() == "Livros Cientificos")
            {
                tipoL = "Livro Cientifico";
            }
            if (comboBox6.SelectedItem.ToString() == "Livros Educativos")
            {
                tipoL = "Livro Educativo";
            }
            if (comboBox6.SelectedItem.ToString() == "Livros de Ficção")
            {
                tipoL = "Livro Ficção";
            }
            if (id.Trim() != "" && nome.Trim() != ""
                && tipoP.Trim() != "" && idL.Trim() != "" && titulo.Trim() != ""
                && tipoL.Trim() != "" && idR.Trim() != "")
            {
                resp = gestor.AddReserva(Convert.ToInt32(idR), Convert.ToInt32(idL), Convert.ToInt32(id), tipoL, tipoP, titulo, nome);
                MessageBox.Show(resp);
                if (resp == "Reserva adicionada com sucesso!")
                {
                    textBox1.Clear();

                }

            }
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
