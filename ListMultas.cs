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
    public partial class ListMultas : Form
    {
        Gestor gestor;
        public ListMultas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {

            foreach (Multa item in gestor.getListaMulta())
            {

                dataGridView1.Rows.Add(item.getIdMulta(), item.getId(),  item.getNome(),item.getTipo(), item.getValor() + "€");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form pagarMulta = new PagarMulta(gestor);
           
            pagarMulta.Show();
        }

        private void ListMultas_Load(object sender, EventArgs e)
        {

        }
    }
}
