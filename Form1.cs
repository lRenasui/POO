using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_BIBLIOTECA
{
    public partial class Form1 : Form
    {
        Gestor gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = new Gestor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListLeitores f2 = new ListLeitores(gestor);
            f2.ShowDialog(); // Shows Form2 you can also use f2.Show() 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ListLivrosE = new ListLivrosE(gestor);
            ListLivrosE.Show(); // Shows Form2 you can also use f2.Show() 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListEmprestimos f2 = new ListEmprestimos(gestor);
            f2.Show(); // Shows Form2 you can also use f2.Show() 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListMultas f2 = new ListMultas(gestor);
            f2.Show(); // Shows Form2 you can also use f2.Show() 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestor.LerFicheiros();
            gestor.Notificacoes();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form ListRevistas = new ListRevistas(gestor);

            ListRevistas.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            gestor.GravarFicheiros();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ListProf = new ListProfessores(gestor);

            ListProf.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form ListReservas = new ListReservas(gestor);

            ListReservas.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form ListJornal = new ListJornais(gestor);

            ListJornal.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form ListEstudantes = new ListEstudantes(gestor);

            ListEstudantes.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form ListSenior = new ListSenior(gestor);

            ListSenior.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form ListLivrosF = new ListLivrosF(gestor);

            ListLivrosF.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form ListLivrosC = new ListLivrosC(gestor);
            ListLivrosC.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form infos = new infos(gestor);
            infos.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form relatorio = new Relatorio(gestor);
            relatorio.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form Editar = new Editar(gestor);
            Editar.Show();
        }
    }

}
