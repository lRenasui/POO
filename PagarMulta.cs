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
    public partial class PagarMulta : Form
    {
        Gestor gestor;
        public PagarMulta(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherComboBox();
        }
        private void PreencherComboBox()
        {

            foreach (Multa item in gestor.getListaMulta())
            {

                comboBox1.Items.Add(item.getIdMulta() + " | " + item.getId() + " - " + item.getTipo() + " - " + item.getNome() + " | " + item.getValor() + "€");
            }
        }
        private void PagarMulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] partes = comboBox1.SelectedItem.ToString().Split(' ');
            string resp = gestor.PagarMulta(Convert.ToInt32(partes[0]));
            MessageBox.Show(resp);
            this.Close();
        }
    }
}
