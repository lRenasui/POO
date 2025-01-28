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
    public partial class Historico : Form
    {
        Gestor gestor;
        public Historico(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
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
        private void PreencherDataGridView(int id, string nome)
        {
            dataGridView1.Rows.Clear();
            foreach (Emprestimo item in gestor.getListaEmprestimo())
            {
                if (item.getIdPessoa() == id && item.getNome() == nome && item.getTipoPessoa() == comboBox1.SelectedItem.ToString())
                {
                    if (item.getEntregue() == "1")
                    {
                        dataGridView1.Rows.Add(item.getIdEmp(), item.getNome(), item.getTitulo(), item.getData().ToString("dd/MM/yyyy"), "Sim");
                    }
                    else if (item.getEntregue() == "0")
                    {
                        dataGridView1.Rows.Add(item.getIdEmp(), item.getNome(), item.getTitulo(), item.getData().ToString("dd/MM/yyyy"), "Não");
                    }
                }
               



            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] partsPessoa;

            
            partsPessoa = comboBox2.SelectedItem.ToString().Split(" - ");
            PreencherDataGridView(Convert.ToInt32(partsPessoa[0]), partsPessoa[1]);
        }
    }
}
