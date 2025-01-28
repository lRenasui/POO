using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_BIBLIOTECA
{
    public class Gestor
    {
        ListEmprestimos ListE;
        private int n_livros_estudantes = 1;
        private int n_dias_estudante = 15;
        private int n_dias_prof = 30;
        private int n_dias_restantes = 7;
        private int n_reservas_estu = 3;
        private int n_reservas_prof = 3;
        private int n_reservas_senior = 1;
        private int n_reservas_leitor = 1;
        private double desconto_prof = 0.50;
        private double desconto_estu = 0.75;
        private List<Revista> ListaRevistas;
        private List<int> ListaEstatisticasLE; //0-Professor 1-Estudante 2-Senior 3-Leitor Comum
        private List<int> ListaEstatisticasLC;
        private List<int> ListaEstatisticasLF;
        private List<int> ListaEstatisticasR;
        private List<int> ListaEstatisticasJ;
        private List<Reserva> ListaReservas;
        private List<LivroEducativo> ListaLivroEducativo;
        private List<LivroCientifico> ListaLivroCientifico;
        private List<Livro> ListaLivro;
        private List<Multa> ListaMulta;
        private List<Emprestimo> ListaEmprestimos;
        private List<LivroFiccao> ListaLivroFiccao;
        private List<Jornal> ListaJornal;
        private List<LeitorComum> ListaLeitorComum;
        private List<Estudante> ListaEstudante;
        private List<Professor> ListaProfessor;
        private List<Senior> ListaSenior;
        public Gestor()
        {
            
            ListaReservas = new List<Reserva>();
            ListaRevistas = new List<Revista>();
            ListaLivroEducativo = new List<LivroEducativo>();
            ListaLivroCientifico = new List<LivroCientifico>();
            ListaLivro = new List<Livro>();
            ListaMulta = new List<Multa>();
            ListaJornal = new List<Jornal>();
            ListaEmprestimos = new List<Emprestimo>();
            ListaLivroFiccao = new List<LivroFiccao>();
            ListaLeitorComum = new List<LeitorComum>();
            ListaEstudante = new List<Estudante>();
            ListaProfessor = new List<Professor>();
            ListaSenior = new List<Senior>();
            ListaEstatisticasLC = new List<int>();
            ListaEstatisticasLE = new List<int>();
            ListaEstatisticasLF = new List<int>();
            ListaEstatisticasR = new List<int>();
            ListaEstatisticasJ = new List<int>();
        }
        public List<Revista> getListaRevistas()
        {
            return ListaRevistas;
        }
        public List<int> getListaEstatisticasLC()
        {
            return ListaEstatisticasLC;
        }
        public List<int> getListaEstatisticasLE()
        {
            return ListaEstatisticasLE;
        }
        public List<int> getListaEstatisticasLF()
        {
            return ListaEstatisticasLF;
        }
        public List<int> getListaEstatisticasR()
        {
            return ListaEstatisticasR;
        }
        public List<int> getListaEstatisticasJ()
        {
            return ListaEstatisticasJ;
        }
        public void setNLivrosMax(int n)
        { this.n_livros_estudantes = n; }
        public int getNLivrosMax()
        {
            return n_livros_estudantes;
        }
        public void setNRE(int n)
        { this.n_reservas_estu = n; }
        public int getNRE()
        {
            return n_reservas_estu;
        }
        public void setNRP(int n)
        { this.n_reservas_prof = n; }
        public int getNRP()
        {
            return n_reservas_prof;
        }
        public void setNRS(int n)
        { this.n_reservas_senior = n; }
       
        public int getNRS()
        {
            return n_reservas_senior;
        }
        public int getNRL()
        {
            return n_reservas_leitor;
        }
        public void setNRL(int n)
        { this.n_reservas_leitor = n; }
        public int getNDiasEstu()
        {
            return n_dias_estudante;
        }
        public void setNDiasEstu(int n)
        { this.n_dias_estudante = n; }
        public int getNDiasProf()
        {
            return n_dias_prof;
        }
        public void setNDiasProf(int n)
        { this.n_dias_prof = n; }
        public int getNdDiasResto()
        {
            return n_dias_restantes;
        }
        public void setNdDiasResto(int n)
        { this.n_dias_restantes = n; }
        public double getDescontoProf()
        {
            return desconto_prof;
        }
        public void setDescontoProf(double n)
        { this.desconto_prof = n; }
        public double getDescontoEstu()
        {
            return desconto_estu;
        }
        public void setDescontoEstu(double n)
        { this.desconto_estu = n; }
        public List<LeitorComum> getListaLeitorComum()
        {
            return ListaLeitorComum;
        }
        public List<Professor> getListaProfessor()
        {
            return ListaProfessor;
        }
        public List<Estudante> getListaEstudantes()
        {
            return ListaEstudante;
        }
        public List<Senior> getListaSeniores()
        {
            return ListaSenior;
        }
        public List<LivroCientifico> getListaLivroCientifico()
        {
            return ListaLivroCientifico;
        }
        public List<LivroFiccao> getListaLivroFiccao()
        {
            return ListaLivroFiccao;
        }
        public List<LivroEducativo> getListaLivroEducativo()
        {
            return ListaLivroEducativo;
        }
        public List<Jornal> getListaJornal()
        {
            return ListaJornal;
        }
        public List<Emprestimo> getListaEmprestimo()
        {
            return ListaEmprestimos;
        }
        public List<Multa> getListaMulta()
        {
            return ListaMulta;
        }
        public List<Reserva> getListaReserva()
        {
            return ListaReservas;
        }
        public string AddRevista(int id, string titulo,string edicao,string autor, string anopub, string isbn)
        {
            string msg = "";

            foreach (Revista R in ListaRevistas)
                if (R.getId().Equals(id))
                {
                    msg = "Revista já existente!";
                    return msg;
                }

            Revista revista = new Revista(id, titulo, autor,edicao, anopub, isbn, "0");
            ListaRevistas.Add(revista);
            msg = "Revista adicionada com sucesso!";
            return msg;
        }
        public string AddLeitor(int id, string nome, int tempodev)
        {
            string msg = "";

            foreach (LeitorComum L in ListaLeitorComum)
                if (L.getIdl().Equals(id))
                {
                    msg = "Leitor já existente!";
                    return msg;
                }

            LeitorComum leitor = new LeitorComum(id, nome, tempodev.ToString());
            ListaLeitorComum.Add(leitor);
            msg = "Leitor adicionado com sucesso!";
            return msg;
        }
        public string AddProfessor(int id, string nome, int tempodev)
        {
            string msg = "";

            foreach (Professor P in ListaProfessor)
                if (P.getIdp().Equals(id))
                {
                    msg = "Professor já existente!";
                    return msg;
                }

            Professor prof = new Professor(id, nome, tempodev.ToString());
            ListaProfessor.Add(prof);
            msg = "Professor adicionado com sucesso!";
            return msg;
        }
        public string AddEstudante(int id, string nome,string ano)
        {
            string msg = "";

            foreach (Estudante E in ListaEstudante)
                if (E.getIde().Equals(id))
                {
                    msg = "Estudante já existente!";
                    return msg;
                }

            Estudante estu = new Estudante(id, nome,ano, 0);
            ListaEstudante.Add(estu);
            msg = "Estudante adicionado com sucesso!";
            return msg;
        }
        public string AddSenior(int id, string nome, int tempodev)
        {
            string msg = "";

            foreach (Senior S in ListaSenior)
                if (S.getIds().Equals(id))
                {
                    msg = "Senior já existente!";
                    return msg;
                }

            Senior senior = new Senior(id, nome, tempodev.ToString());
            ListaSenior.Add(senior);
            msg = "Senior adicionado com sucesso!";
            return msg;
        }
        public string AddLivroCientifico(int id, string titulo, string autor, string area, string anopub, string isbn)
        {
            string msg = "";

            foreach (LivroCientifico LC in ListaLivroCientifico)
                if (LC.getId().Equals(id))
                {
                    msg = "Livro Cientifico já existente!";
                    return msg;
                }

            LivroCientifico LivroC = new LivroCientifico(id, titulo, autor, area, anopub, isbn,"0");
            ListaLivroCientifico.Add(LivroC);
            msg = "Livro Cientifico adicionado com sucesso!";
            return msg;
        }
        public string AddLivroFiccao(int id, string titulo, string autor, string anopub, string isbn)
        {
            string msg = "";

            foreach (LivroFiccao LF in ListaLivroFiccao)
                if (LF.getId().Equals(id))
                {
                    msg = "Livro de Ficção já existente!";
                    return msg;
                }

            LivroFiccao LivroF = new LivroFiccao(id, titulo, autor, anopub, isbn, "0");
            ListaLivroFiccao.Add(LivroF);
            msg = "Livro de Ficção adicionado com sucesso!";
            return msg;
        }
        public string AddLivroEducativo(int id, string titulo, string autor, string anoesc, string anopub, string isbn)
        {
            string msg = "";

            foreach (LivroEducativo LE in ListaLivroEducativo)
                if (LE.getId().Equals(id))
                {
                    msg = "Livro Educativo já existente!";
                    return msg;
                }

            LivroEducativo LivroE = new LivroEducativo(id, titulo, autor, anoesc, anopub, isbn, "0");
            ListaLivroEducativo.Add(LivroE);
            msg = "Livro Educativo adicionado com sucesso!";
            return msg;
        }
        public string AddJornal(int id, string titulo, string autor, string anopub, string edicao, string categoria, string issn)
        {
            string msg = "";

            foreach (Jornal J in ListaJornal)
                if (J.getId().Equals(id))
                {
                    msg = "Jornal já existente!";
                    return msg;
                }

            Jornal Jo = new Jornal(id, titulo, autor, anopub,edicao,categoria, issn, "0");
            ListaJornal.Add(Jo);
            msg = "Jornal adicionado com sucesso!";
            return msg;
        }
        public string AddEmprestimo(int idEmp, int idL, int idP, string tipolivro, string tipopessoa, string titulo, string nome, DateTime data)
        {
            string msg = "";
            
            foreach (Emprestimo E in ListaEmprestimos.ToList())
            {
                if (E.getIdEmp().Equals(idEmp))
                {
                    msg = "Emprestimo já existente!";
                    return msg;
                }
                
            }
            if (tipopessoa == "Estudante")
            {

                foreach (Estudante item in ListaEstudante)
                {


                    if (item.getNLivros() >= n_livros_estudantes && item.getIde() == idP)
                    {
                        msg = "Este Estudante não pode requsitar mais livros até devolver os que tem.";
                        return msg;
                    }
                    else if (item.getNLivros() < n_livros_estudantes && item.getIde() == idP)
                    {
                        
                        Emprestimo Emp2 = new Emprestimo(idEmp, idL, idP, tipolivro, tipopessoa, nome, titulo, data, "0");
                        ListaEmprestimos.Add(Emp2);
                        var obj = ListaEstudante.FirstOrDefault(x => x.getIde() == idP);
                        if (obj != null) obj.setNLivros(obj.getNLivros() + 1);
                        
                        if (tipolivro == "Revista")
                        {
                            var obj2 = ListaRevistas.FirstOrDefault(x => x.getId() == idL);
                            if (obj2 != null) obj2.setEmprestado("1");
                            ListaEstatisticasR[1] = Convert.ToInt32(ListaEstatisticasR[1]) + 1;
                        }
                        else if (tipolivro == "Jornal")
                        {
                            var obj2 = ListaJornal.FirstOrDefault(x => x.getId() == idL);
                            if (obj2 != null) obj2.setEmprestado("1");
                            ListaEstatisticasJ[1] = Convert.ToInt32(ListaEstatisticasJ[1]) + 1;
                        }
                        else if (tipolivro == "Livro Cientifico")
                        {
                            var obj2 = ListaLivroCientifico.FirstOrDefault(x => x.getId() == idL);
                            if (obj2 != null) obj2.setEmprestado("1");
                            ListaEstatisticasLC[1] = Convert.ToInt32(ListaEstatisticasLC[1]) + 1;
                        }
                        else if (tipolivro == "Livro Educativo")
                        {
                            var obj2 = ListaLivroEducativo.FirstOrDefault(x => x.getId() == idL);
                            if (obj2 != null) obj2.setEmprestado("1");
                            ListaEstatisticasLE[1] = Convert.ToInt32(ListaEstatisticasLE[1]) + 1;
                        }
                        else if (tipolivro == "Livro Ficção")
                        {
                            var obj2 = ListaLivroFiccao.FirstOrDefault(x => x.getId() == idL);
                            if (obj2 != null) obj2.setEmprestado("1");
                            ListaEstatisticasLF[1] = Convert.ToInt32(ListaEstatisticasLF[1]) + 1;
                        }
                        
                        msg = "Emprestimo adicionado com sucesso!";
                        return msg;
                    }

                }
            }
            if (tipopessoa == "Professor")
            {
                if (tipolivro == "Revista")
                {
                    ListaEstatisticasR[0] = Convert.ToInt32(ListaEstatisticasR[0]) + 1;
                }
                else if (tipolivro == "Jornal")
                {
                    ListaEstatisticasJ[0] = Convert.ToInt32(ListaEstatisticasJ[0]) + 1;
                }
                else if (tipolivro == "Livro Cientifico")
                {
                    ListaEstatisticasLC[0] = Convert.ToInt32(ListaEstatisticasLC[0]) + 1;
                }
                else if (tipolivro == "Livro Educativo")
                {
                    ListaEstatisticasLE[0] = Convert.ToInt32(ListaEstatisticasLE[0]) + 1;
                }
                else if (tipolivro == "Livro Ficção")
                {
                    ListaEstatisticasLF[0] = Convert.ToInt32(ListaEstatisticasLF[0]) + 1;
                }
            }
            if (tipopessoa == "Senior")
            {
                if (tipolivro == "Revista")
                {
                    ListaEstatisticasR[2] = Convert.ToInt32(ListaEstatisticasR[2]) + 1;
                }
                else if (tipolivro == "Jornal")
                {
                    ListaEstatisticasJ[2] = Convert.ToInt32(ListaEstatisticasJ[2]) + 1;
                }
                else if (tipolivro == "Livro Cientifico")
                {
                    ListaEstatisticasLC[2] = Convert.ToInt32(ListaEstatisticasLC[2]) + 1;
                }
                else if (tipolivro == "Livro Educativo")
                {
                    ListaEstatisticasLE[2] = Convert.ToInt32(ListaEstatisticasLE[2]) + 1;
                }
                else if (tipolivro == "Livro Ficção")
                {
                    ListaEstatisticasLF[2] = Convert.ToInt32(ListaEstatisticasLF[2]) + 1;
                }
            }
            if (tipopessoa == "Leitor Comum")
            {
                if (tipolivro == "Revista")
                {
                    ListaEstatisticasR[3] = Convert.ToInt32(ListaEstatisticasR[3]) + 1;
                }
                else if (tipolivro == "Jornal")
                {
                    ListaEstatisticasJ[3] = Convert.ToInt32(ListaEstatisticasJ[3]) + 1;
                }
                else if (tipolivro == "Livro Cientifico")
                {
                    ListaEstatisticasLC[3] = Convert.ToInt32(ListaEstatisticasLC[3]) + 1;
                }
                else if (tipolivro == "Livro Educativo")
                {
                    ListaEstatisticasLE[3] = Convert.ToInt32(ListaEstatisticasLE[3]) + 1;
                }
                else if (tipolivro == "Livro Ficção")
                {
                    ListaEstatisticasLF[3] = Convert.ToInt32(ListaEstatisticasLF[3]) + 1;
                }
            }

            Emprestimo Emp = new Emprestimo(idEmp,idL,idP,tipolivro,tipopessoa,nome, titulo, data,"0");
            ListaEmprestimos.Add(Emp);
            msg = "Emprestimo adicionado com sucesso!";
            return msg;
        }
        public string AddMulta(int idmulta, int id, string nome, string tipoP, int valor)
        {
            string msg = "";

            foreach (Multa M in ListaMulta)
            {
                if (M.getIdMulta().Equals(idmulta))
                {
                    msg = "Multa já existente!";
                    return msg;
                }
            }



            Multa multa = new Multa(idmulta,id,nome,tipoP,valor);
            ListaMulta.Add(multa);
            msg = "Multa adicionada com sucesso!";
            return msg;
        }
        public string AddReserva(int idReserva, int idlivro, int idpessoa, string tipoL, string tipoP, string nome, string titulo)
        {
            string msg = "";
            int contador = 0;
            foreach (Reserva R in ListaReservas)
            {
                if (R.getIdReserva().Equals(idReserva))
                {
                    msg = "Reserva já existente!";
                    return msg;
                }
            }
            if (tipoP == "Estudante")
            {
                foreach (Reserva item in ListaReservas)
                {
                    if (item.getIdPessoa() == idpessoa)
                    {
                        contador++;
                    }
                }
                if (n_reservas_estu >= contador && contador != 0)
                {
                    msg = "Este Estudante não pode fazer mais reservas!";
                    return msg;
                }
            }
            if (tipoP == "Professor")
            {
                foreach (Reserva item in ListaReservas)
                {
                    if (item.getIdPessoa() == idpessoa)
                    {
                        contador++;
                    }
                }
                if (n_reservas_prof >= contador && contador != 0)
                {
                    msg = "Este Professor não pode fazer mais reservas!";
                    return msg;
                }
            }
            if (tipoP == "Senior")
            {
                foreach (Reserva item in ListaReservas)
                {
                    if (item.getIdPessoa() == idpessoa)
                    {
                        contador++;
                    }
                }
                if (n_reservas_senior >= contador && contador != 0)
                {
                    msg = "Este Senior não pode fazer mais reservas!";
                    return msg;
                }
            }
            if (tipoP == "Leitor Comum")
            {
                foreach (Reserva item in ListaReservas)
                {
                    if (item.getIdPessoa() == idpessoa)
                    {
                        contador++;
                    }
                }
                if (n_reservas_leitor >= contador && contador != 0)
                {
                    msg = "Este Leitor Comum não pode fazer mais reservas!";
                    return msg;
                }
            }


            Reserva reserva = new Reserva(idReserva,idlivro,idpessoa,tipoL,tipoP,nome,titulo);
            ListaReservas.Add(reserva);
            msg = "Reserva adicionada com sucesso!";
            return msg;
        }
        public string PagarMulta(int idmulta)
        {
            string msg = "";

            foreach (Multa M in ListaMulta)
            {
                if (M.getIdMulta().Equals(idmulta))
                {
                    Multa multa = new Multa(idmulta, M.getId(), M.getNome(), M.getTipo(), M.getValor());
                    
                    ListaMulta.Remove(ListaMulta.Where(multa => multa.getIdMulta() == idmulta).First());
                    msg = "Multa Paga!";
                    return msg;
                }
                
            }
            return msg;
        }
        public void Notificacoes()
        {
            string msg = "";

            foreach (Emprestimo E in ListaEmprestimos)
            {

                if (E.getData().Date < DateTime.Now.Date && E.getEntregue()=="0")
                {
                    MessageBox.Show("O " + E.getNome() + " ainda não devolvou o " + E.getTitulo() + ". A data de entrega era " + E.getData().ToString("dd/MM/yyyy"));
                }




            }
        }
        public void Atualizar(string DE,string DP,string NDR, string NDP, string NDE, string NL, string NRL, string NRS, string NRE, string NRP)
        {
            setDescontoEstu(Convert.ToDouble(DE) / 100);
            setDescontoProf(Convert.ToDouble(DP) / 100);
            setNdDiasResto(Convert.ToInt32(NDR));
            setNDiasEstu(Convert.ToInt32(NDE));
            setNDiasProf(Convert.ToInt32(NDP));
            setNLivrosMax(Convert.ToInt32(NL));
            setNRE(Convert.ToInt32(NRE));
            setNRP(Convert.ToInt32(NRP));
            setNRS(Convert.ToInt32(NRS));
            setNRL(Convert.ToInt32(NRL));
            MessageBox.Show("Dados Atualizados");
        }
        public void Editar(int id, string titulo, string autor, string anoesc, string anopub, string area, string edicao, string categoria, string isbn, string issn, string tipo)
        {
            
            if (tipo == "Livro Educativo")
            {

                foreach (LivroEducativo item in getListaLivroEducativo())
                {
                    if (item.getId()== id)
                    {
                        item.setTitulo(titulo);
                        item.setAutor(autor);
                        item.setAnoesc(anoesc);
                        item.setAnopub(anopub);
                        item.setIsbn(isbn);
                        MessageBox.Show("Livro Educativo Editado");
                        return;
                    }
                }
            }
            if (tipo == "Livro Cientifico")
            {
                
                foreach (LivroCientifico item in getListaLivroCientifico())
                {
                    if (item.getId() == id)
                    {
                        item.setTitulo(titulo);
                        item.setAutor(autor);
                        item.setArea(area);
                        item.setAnopub(anopub);
                        item.setIsbn(isbn);
                        MessageBox.Show("Livro Cientifico Editado");
                        return;
                    }
                }
            }
            if (tipo == "Livro Ficção")
            {
                
                foreach (LivroFiccao item in getListaLivroFiccao())
                {
                    if (item.getId() == id)
                    {
                        item.setTitulo(titulo);
                        item.setAutor(autor);
                        item.setAnopub(anopub);
                        item.setIsbn(isbn);
                        MessageBox.Show("Livro Ficção Editado");
                        return;
                    }
                }
            }
            if (tipo == "Jornal")
            {
                
                foreach (Jornal item in getListaJornal())
                {
                    if (item.getId() == id)
                    {
                        item.setTitulo(titulo);
                        item.setAutor(autor);
                        item.setAnopub(anopub);
                        item.setIssn(issn);
                        item.setCategoria(categoria);
                        item.setEdicao(edicao);
                        MessageBox.Show("Jornal Editado");
                        return;
                    }
                }
            }
            if (tipo == "Revista")
            {
                
                foreach (Revista item in getListaRevistas())
                {
                    if (item.getId() == id)
                    {
                        item.setTitulo(titulo);
                        item.setAutor(autor);
                        item.setAnopub(anopub);
                        item.setIsbn(issn);
                        item.setEdicao(edicao);
                        MessageBox.Show("Revista Editada");
                        return;
                    }
                }
            }
        }
        public void Prorrogar(int id)
        {

            

                foreach (Emprestimo item in getListaEmprestimo())
                {
                    if (item.getIdEmp() == id && item.getTipoPessoa() =="Estudante")
                    {
                    item.setData(item.getData().AddDays(7));
                        MessageBox.Show("Emprestimo prorrogado 7 dias");
                        return;
                    }
                if (item.getIdEmp() == id && item.getTipoPessoa() == "Professor")
                {
                    item.setData(item.getData().AddDays(7));
                    MessageBox.Show("Emprestimo prorrogado 7 dias");
                    return;
                }
            }
            MessageBox.Show("Este Leitor não pode prorrogar emprestimos.");
            return;

        }
        public string AcabarEmprestimo(int id)
        {
            string msg = "";

            foreach (Emprestimo E in ListaEmprestimos)
            {
                if (E.getIdEmp().Equals(id))
                {
                    if (E.getData().Date < DateTime.Now.Date)
                    {
                        if (E.getTipoPessoa() == "Professor")
                        {

                            Multa multa = new Multa(E.getIdPessoa(), ListaMulta[ListaMulta.Count].getIdMulta() + 1, E.getNome(), E.getTipoPessoa(), Convert.ToInt32(10*getDescontoProf()));
                            ListaMulta.Add(multa);
                            var obj = ListaEmprestimos.FirstOrDefault(x => x.getIdEmp() == id);
                            if (obj != null) obj.setEntregue("1");
                           
                            msg = "Livro entregue. Como Entregou depois da data estipulada, tem uma multa de " + (10 * getDescontoProf())+"€ para pagar.";
                            return msg;
                        }
                        if (E.getTipoPessoa() == "Estudante")
                        {
                            
                            Multa multa = new Multa(E.getIdPessoa(), ListaMulta[ListaMulta.Count].getIdMulta() + 1, E.getNome(), E.getTipoPessoa(), Convert.ToInt32(10 * getDescontoEstu()));
                            ListaMulta.Add(multa);
                            var obj = ListaEmprestimos.FirstOrDefault(x => x.getIdEmp() == id);
                            if (obj != null) obj.setEntregue("1");
                            var obj2 = ListaEstudante.FirstOrDefault(x => x.getIde() == E.getIdPessoa());
                            if (obj2 != null) obj2.setNLivros(obj2.getNLivros() - 1);
                            msg = "Livro entregue. Como Entregou depois da data estipulada, tem uma multa de " + (10 * getDescontoEstu())+"€ para pagar.";
                            return msg;
                        }
                        else
                        {
                            Multa multa = new Multa( ListaMulta[ListaMulta.Count-1].getIdMulta() + 1, E.getIdPessoa(), E.getNome(), E.getTipoPessoa(), 10);
                            ListaMulta.Add(multa);
                            var obj = ListaEmprestimos.FirstOrDefault(x => x.getIdEmp() == id);
                            if (obj != null) obj.setEntregue("1");
                            msg = "Livro entregue. Como Entregou depois da data estipulada, tem uma multa de 10€ para pagar.";
                            return msg;
                        }
                    }
                    else {
                        if (E.getTipoPessoa() == "Estudante")
                        {

                            var obj2 = ListaEstudante.FirstOrDefault(x => x.getIde() == E.getIdPessoa());
                            if (obj2 != null) obj2.setNLivros(obj2.getNLivros() - 1);
                        }
                        if (E.getTipoLivro() == "Jornal")
                        {

                            var obj2 = ListaJornal.FirstOrDefault(x => x.getId() == E.getIdlivro());
                            if (obj2 != null) obj2.setEmprestado("1");
                        }
                        if (E.getTipoLivro() == "Revista")
                        {

                            var obj2 = ListaRevistas.FirstOrDefault(x => x.getId() == E.getIdlivro());
                            if (obj2 != null) obj2.setEmprestado("1");
                        }
                        if (E.getTipoLivro() == "Livro Cientifico")
                        {

                            var obj2 = ListaLivroCientifico.FirstOrDefault(x => x.getId() == E.getIdlivro());
                            if (obj2 != null) obj2.setEmprestado("1");
                        }
                        if (E.getTipoLivro() == "Livro Educativo")
                        {

                            var obj2 = ListaLivroEducativo.FirstOrDefault(x => x.getId() == E.getIdlivro());
                            if (obj2 != null) obj2.setEmprestado("1");
                        }
                        if (E.getTipoLivro() == "Livro Ficção")
                        {

                            var obj2 = ListaLivroFiccao.FirstOrDefault(x => x.getId() == E.getIdlivro());
                            if (obj2 != null) obj2.setEmprestado("1");
                        }
                        var obj = ListaEmprestimos.FirstOrDefault(x => x.getIdEmp() == id);
                        if (obj != null) obj.setEntregue("1");
                        msg = "Livro entregue.";
                        return msg;
                    }
                   
                }

            }
            
            return msg;
        }
        public void GravarFicheiros()
        {
            
            //___________Revista_____________
            StreamWriter f = new StreamWriter("Revista.txt");
            foreach (Revista item in ListaRevistas)
            {
                f.WriteLine(item.getId().ToString()+","+ item.getTitulo() + "," +
                    item.getAutor() + "," +item.getEdicao() + "," +item.getAnopub() + "," +item.getIsbn() + "," + item.getEmprestado());
            }
            f.Close();
            //___________LivroEducativo_____________

            StreamWriter f1 = new StreamWriter("LivroEducativo.txt");
            foreach (LivroEducativo item in ListaLivroEducativo)
            {
                f1.WriteLine(item.getId().ToString() + "," + item.getTitulo() + "," +
                    item.getAutor() + "," + item.getAnoesc() + "," + item.getAnopub() + "," + item.getIsbn() + "," + item.getEmprestado());
            }
            f1.Close();

            //___________LivroCientifico_____________
            StreamWriter f2 = new StreamWriter("LivroCientifico.txt");
            foreach (LivroCientifico item in ListaLivroCientifico)
            {
                f2.WriteLine(item.getId().ToString() + "," + item.getTitulo() + "," +
                    item.getAutor() + "," + item.getArea() + "," + item.getAnopub() + "," + item.getIsbn() + "," + item.getEmprestado());
            }
            f2.Close();

            //___________Reserva_____________

            StreamWriter f3 = new StreamWriter("Reserva.txt");
            foreach (Reserva item in ListaReservas)
            {
                f3.WriteLine(item.getIdReserva().ToString() + "," + item.getIdlivro().ToString() + "," + item.getIdPessoa().ToString() + "," + item.getTipoLivro()+"," + item.getTipoPessoa() + "," + item.getNome() + "," + item.getTitulo());
            }
            f3.Close();
            //___________Multa_____________
            StreamWriter f4 = new StreamWriter("Multa.txt");
            foreach (Multa item in ListaMulta)
            {
                f4.WriteLine(item.getIdMulta().ToString() + "," + item.getId().ToString() + "," + item.getNome() + "," + item.getTipo() + "," + item.getValor().ToString());
            }
            f4.Close();
            //___________Emprestimos_____________
            StreamWriter f5 = new StreamWriter("Emprestimo.txt");
            foreach (Emprestimo item in ListaEmprestimos)
            {
                f5.WriteLine(item.getIdEmp().ToString() + "," + item.getIdlivro().ToString() + "," + item.getIdPessoa().ToString() + "," + item.getTipoLivro() + "," + item.getTipoPessoa() + "," + item.getNome() + "," + item.getTitulo() + "," + item.getData().ToString() + "," + item.getEntregue());
            }
            f5.Close();
            //___________LivroFiccao_____________
            StreamWriter f6 = new StreamWriter("LivroFiccao.txt");
            foreach (LivroFiccao item in ListaLivroFiccao)
            {
                f6.WriteLine(item.getId().ToString() + "," + item.getTitulo() + "," + item.getAutor() + "," + item.getAnopub() + "," + item.getIsbn() + "," + item.getEmprestado());
            }
            f6.Close();
            //___________Jornal_____________

            StreamWriter f7 = new StreamWriter("Jornal.txt");
            foreach (Jornal item in ListaJornal)
            {
                f7.WriteLine(item.getId().ToString() + "," + item.getTitulo() + "," + item.getAutor() + "," + item.getAnopub() + "," + item.getEdicao() + "," + item.getCategoria() + "," + item.getIssn() + "," + item.getEmprestado());
            }
            f7.Close();
            //___________LeitorComum_____________
            StreamWriter f8 = new StreamWriter("LeitorComum.txt");
            foreach (LeitorComum item in ListaLeitorComum)
            {
                f8.WriteLine(item.getIdl().ToString() + "," + item.getNome() + "," + item.getTempodev());
            }
            f8.Close();
            //___________Estudante_____________
            StreamWriter f9 = new StreamWriter("Estudante.txt");
            foreach (Estudante item in ListaEstudante)
            {
                f9.WriteLine(item.getIde().ToString() + "," + item.getNome() + "," + item.getAno() + "," + item.getNLivros());
            }
            f9.Close();
            //___________Professor_____________

            StreamWriter f10 = new StreamWriter("Professor.txt");
            foreach (Professor item in ListaProfessor)
            {
                f10.WriteLine(item.getIdp().ToString() + "," + item.getNome()+ "," + item.getTempodev());
            }
            f10.Close();
            //___________Senior_____________

            StreamWriter f11 = new StreamWriter("Senior.txt");
            foreach (Senior item in ListaSenior)
            {
                f11.WriteLine(item.getIds().ToString() + "," + item.getNome() + "," + item.getTempodev());
            }
            f11.Close();
            //___________estatisticas_____________
            StreamWriter f12 = new StreamWriter("estatisticas.txt");

            f12.WriteLine(ListaEstatisticasLC[0] + "," + ListaEstatisticasLC[1] + "," + ListaEstatisticasLC[2] + "," + ListaEstatisticasLC[3]);
            f12.WriteLine(ListaEstatisticasLE[0] + "," + ListaEstatisticasLE[1] + "," + ListaEstatisticasLE[2] + "," + ListaEstatisticasLE[3]);
            f12.WriteLine(ListaEstatisticasLF[0] + "," + ListaEstatisticasLF[1] + "," + ListaEstatisticasLF[2] + "," + ListaEstatisticasLF[3]);
            f12.WriteLine(ListaEstatisticasR[0] + "," + ListaEstatisticasR[1] + "," + ListaEstatisticasR[2] + "," + ListaEstatisticasR[3]);
            f12.WriteLine(ListaEstatisticasJ[0] + "," + ListaEstatisticasJ[1] + "," + ListaEstatisticasJ[2] + "," + ListaEstatisticasJ[3]);
            f12.Close();
        }
        public void LerFicheiros()
        {
           
            //___________Revista_____________
            StreamReader f = new StreamReader("Revista.txt");
            string linha = "";
            string[] parts;
            linha = f.ReadLine();
            while (linha != null)
            {
                parts = linha.Split(',');

                int id = Convert.ToInt32(parts[0]);
                string tit = parts[1];
                string autor = parts[2];
                string isbn = parts[5];
                string edicao = parts[3];
                string ano_pub = parts[4];

                Revista revista = new Revista(id, tit, autor, edicao, ano_pub, isbn, parts[6]);

                ListaRevistas.Add(revista);
                linha = f.ReadLine();
            }

            f.Close();
            //___________LivroEducativo_____________
            StreamReader f1 = new StreamReader("LivroEducativo.txt");
            string linha1 = "";
            string[] parts1;
            linha1 = f1.ReadLine();
            while (linha1 != null)
            {
                parts1 = linha1.Split(',');
                int id = Convert.ToInt32(parts1[0]);
                string tit = parts1[1];
                string autor = parts1[2];
                
                string ano_esc = parts1[3];
                string ano_pub = parts1[4];
                string isbn = parts1[5];

                LivroEducativo livroeducativo = new LivroEducativo(id, tit, autor, ano_esc, ano_pub, isbn, parts1[6]);

                ListaLivroEducativo.Add(livroeducativo);
                linha1 = f1.ReadLine();
            }
            f1.Close();

            //___________LivroCientifico_____________

            StreamReader f2 = new StreamReader("LivroCientifico.txt");
            string linha2 = "";
            string[] parts2;
            linha2 = f2.ReadLine();
            while (linha2 != null)
            {
                parts2 = linha2.Split(',');

                int id = Convert.ToInt32(parts2[0]);
                string tit = parts2[1];
                string autor = parts2[2];
                string isbn = parts2[5];
                string area = parts2[3];
                string ano_pub = parts2[4];

                LivroCientifico livrocientifico = new LivroCientifico(id, tit, autor, area, ano_pub, isbn, parts2[6]);

                ListaLivroCientifico.Add(livrocientifico);
                linha2 = f2.ReadLine();
            }
            f2.Close();

            //___________Reserva_____________
            StreamReader f3 = new StreamReader("Reserva.txt");
            string linha3 = "";
            string[] parts3;
            linha3 = f3.ReadLine();
            while (linha3 != null)
            {
                parts3 = linha3.Split(',');

                int idR = Convert.ToInt32(parts3[0]);
                int idL = Convert.ToInt32(parts3[1]);
                int idP = Convert.ToInt32(parts3[2]);
                string tipoL = parts3[3];
                string tipoP = parts3[4];
                string nome = parts3[5];
                string titulo = parts3[6];


                Reserva reserva = new Reserva(idR,idL,idP,tipoL,tipoP,nome,titulo);

                ListaReservas.Add(reserva);
                linha3 = f3.ReadLine();
            }
            f3.Close();
            //___________Multa_____________

            StreamReader f4 = new StreamReader("Multa.txt");
            string linha4 = "";
            string[] parts4;
            linha4 = f4.ReadLine();
            while (linha4 != null)
            {
                parts4 = linha4.Split(',');

                int idmulta = Convert.ToInt32(parts4[0]);
                int id = Convert.ToInt32(parts4[1]);
                string nome = parts4[2];
                string tipo = parts4[3];
                int valor = Convert.ToInt32(parts4[4]);


                Multa multa = new Multa(idmulta, id, nome,tipo, valor);

                ListaMulta.Add(multa);
                linha4 = f4.ReadLine();
            }
            f4.Close();
            //___________Emprestimos_____________
            StreamReader f5 = new StreamReader("Emprestimo.txt");
            string linha5 = "";
            string[] parts5;
            linha5 = f5.ReadLine();
            while (linha5 != null)
            {
                parts5 = linha5.Split(',');

                int idE = Convert.ToInt32(parts5[0]);
                int idL = Convert.ToInt32(parts5[1]);
                int idP = Convert.ToInt32(parts5[2]);
                string tipoL = parts5[3];
                string tipoP = parts5[4];
                string nome = parts5[5];
                string titulo = parts5[6];
                DateTime data = Convert.ToDateTime(parts5[7]);
                string entregue = parts5[8];



                Emprestimo emprestimo = new Emprestimo(idE, idL, idP, tipoL, tipoP, nome, titulo,data,entregue);

                ListaEmprestimos.Add(emprestimo);
                linha5 = f5.ReadLine();
            }
            f5.Close();
            //___________LivroFiccao_____________
            StreamReader f6 = new StreamReader("LivroFiccao.txt");
            string linha6 = "";
            string[] parts6;
            linha6 = f6.ReadLine();
            while (linha6 != null)
            {
                parts6 = linha6.Split(',');


                int id = Convert.ToInt32(parts6[0]);
                string tit = parts6[1];
                string autor = parts6[2];
                string isbn = parts6[4];
                string ano_pub = parts6[3];

                LivroFiccao livroficcao = new LivroFiccao(id, tit, autor, ano_pub, isbn, parts6[5]);

                ListaLivroFiccao.Add(livroficcao);
                linha6 = f6.ReadLine();
            }
            f6.Close();
            //___________Jornal_____________
            StreamReader f7 = new StreamReader("Jornal.txt");
            string linha7 = "";
            string[] parts7;
            linha7 = f7.ReadLine();
            while (linha7 != null)
            {
                parts7 = linha7.Split(',');

                int id = Convert.ToInt32(parts7[0]);
                string tit = parts7[1];
                string autor = parts7[2];
                string issn = parts7[6];
                string edicao = parts7[4];
                string ano_pub = parts7[3];
                string categoria = parts7[5];

                Jornal jornal = new Jornal(id, tit, autor, ano_pub, edicao, categoria, issn, parts7[7]);

                ListaJornal.Add(jornal);
                linha7 = f7.ReadLine();
            }
            f7.Close();
            //___________LeitorComum_____________

            StreamReader f8 = new StreamReader("LeitorComum.txt");
            string linha8 = "";
            string[] parts8;
            linha8 = f8.ReadLine();
            while (linha8 != null)
            {
                parts8 = linha8.Split(',');

                int idl = Convert.ToInt32(parts8[0]);
                string nome = parts8[1];
                string tempodev = parts8[2];




                LeitorComum leitorcomum = new LeitorComum(idl, nome, tempodev);

                ListaLeitorComum.Add(leitorcomum);
                linha8 = f8.ReadLine();
            }
            f8.Close();
            //___________Estudante_____________
 
            StreamReader f9 = new StreamReader("Estudante.txt");
            string linha9 = "";
            string[] parts9;
            linha9 = f9.ReadLine();
            while (linha9 != null)
            {
                parts9 = linha9.Split(',');

                int ide = Convert.ToInt32(parts9[0]);
                string nome = parts9[1];
                string ano = parts9[2];
                int nlivros = Convert.ToInt32(parts9[3]);



                Estudante estudante = new Estudante(ide, nome, ano, nlivros);

                ListaEstudante.Add(estudante);
                linha9 = f9.ReadLine();
            }
            f9.Close();
            //___________Professor_____________
            
            StreamReader f10 = new StreamReader("Professor.txt");
            string linha10 = "";
            string[] parts10;
            linha10 = f10.ReadLine();
            while (linha10 != null)
            {
                parts10 = linha10.Split(',');

                int idp = Convert.ToInt32(parts10[0]);
                string nome = parts10[1];
                string tempodev = parts10[2];



                Professor professor = new Professor(idp, nome, tempodev);

                ListaProfessor.Add(professor);
                linha10 = f10.ReadLine();
            }
            f10.Close();
            //___________Senior_____________
            StreamReader f11 = new StreamReader("Senior.txt");
            string linha11 = "";
            string[] parts11;
            linha11 = f11.ReadLine();
            while (linha11 != null)
            {
                parts11 = linha11.Split(',');

                int ids = Convert.ToInt32(parts11[0]);
                string nome = parts11[1];
                string tempodev = parts11[2];


                Senior senior = new Senior(ids, nome, tempodev);

                ListaSenior.Add(senior);
                linha11 = f11.ReadLine();
            }
            f11.Close();
            // ___________Estatistica_____________
            
            StreamReader f12 = new StreamReader("estatisticas.txt");
            string linha12 = "";
            string[] parts12;
            linha12 = f12.ReadLine();
            
                parts12 = linha12.Split(',');

            ListaEstatisticasLC.Add(Convert.ToInt32(parts12[0]));
            ListaEstatisticasLC.Add(Convert.ToInt32(parts12[1]));
            ListaEstatisticasLC.Add(Convert.ToInt32(parts12[2]));
            ListaEstatisticasLC.Add(Convert.ToInt32(parts12[3]));
            linha12 = f12.ReadLine();

            parts12 = linha12.Split(',');

            ListaEstatisticasLE.Add(Convert.ToInt32(parts12[0]));
            ListaEstatisticasLE.Add(Convert.ToInt32(parts12[1]));
            ListaEstatisticasLE.Add(Convert.ToInt32(parts12[2]));
            ListaEstatisticasLE.Add(Convert.ToInt32(parts12[3]));
            linha12 = f12.ReadLine();

            parts12 = linha12.Split(',');

            ListaEstatisticasLF.Add(Convert.ToInt32(parts12[0]));
            ListaEstatisticasLF.Add(Convert.ToInt32(parts12[1]));
            ListaEstatisticasLF.Add(Convert.ToInt32(parts12[2]));
            ListaEstatisticasLF.Add(Convert.ToInt32(parts12[3]));
            linha12 = f12.ReadLine();

            parts12 = linha12.Split(',');

            ListaEstatisticasR.Add(Convert.ToInt32(parts12[0]));
            ListaEstatisticasR.Add(Convert.ToInt32(parts12[1]));
            ListaEstatisticasR.Add(Convert.ToInt32(parts12[2]));
            ListaEstatisticasR.Add(Convert.ToInt32(parts12[3]));
            linha12 = f12.ReadLine();

            parts12 = linha12.Split(',');

            ListaEstatisticasJ.Add(Convert.ToInt32(parts12[0]));
            ListaEstatisticasJ.Add( Convert.ToInt32(parts12[1]));
            ListaEstatisticasJ.Add(Convert.ToInt32(parts12[2]));
            ListaEstatisticasJ.Add(Convert.ToInt32(parts12[3]));
            f12.Close();
        }
    }
}
