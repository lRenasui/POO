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
    public partial class ListReservas : Form
    {
        Gestor gestor;
        public ListReservas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {
            foreach (Reserva item in gestor.getListaReserva())
            {
                dataGridView1.Rows.Add(item.getIdReserva(), item.getNome(), item.getTitulo());

            }
        }

        private void ListReservas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form AddReserva = new AddReserva(gestor);
            
            AddReserva.Show();
        }
    }
}
