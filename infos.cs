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
    public partial class infos : Form
    {
        Gestor gestor;
        public infos(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.Atualizar(textBox4.Text, textBox5.Text, textBox3.Text, textBox2.Text, textBox1.Text, textBox6.Text, textBox10.Text, textBox9.Text, textBox7.Text, textBox8.Text);
        }

        private void infos_Load(object sender, EventArgs e)
        {
            textBox1.Text = gestor.getNDiasEstu().ToString();
            textBox2.Text = gestor.getNDiasProf().ToString();
            textBox3.Text = gestor.getNdDiasResto().ToString();
            textBox4.Text = (gestor.getDescontoEstu()*100).ToString();
            textBox5.Text = (gestor.getDescontoProf() * 100).ToString();
            textBox6.Text = gestor.getNLivrosMax().ToString();
            textBox7.Text = gestor.getNRE().ToString();
            textBox8.Text = gestor.getNRP().ToString();
            textBox9.Text = gestor.getNRS().ToString();
            textBox10.Text = gestor.getNRL().ToString();
        }
    }
}
