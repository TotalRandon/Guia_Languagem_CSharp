using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public partial class ContasUsuarios : Form
    {
        public Conta[] ListaContas = new Conta[50];
        private int TamLista = 0;

        public ContasUsuarios()
        {
            InitializeComponent();
        }

        public void InicializaLista(Conta[] Lista)
        {
            int Cont;

            for (Cont = 0; Cont < 50; Cont++)
            {
                Lista[Cont] = new Conta(0,0,0);
            }

            this.TamLista = 0;
        }

        public void ApagaContas(Conta[] Lista)
        {
            int Cont;

            for (Cont = 0; Cont < 50; Cont++)
            {
                Lista[Cont].GravaConta(0, 0, 0);
            }

            this.TamLista = 0;
        }

        public void MostraContas(Conta[] Lista)
        {
            int Cont;

            lbxContas.Items.Clear();
            for (Cont = 0; Cont < this.TamLista; Cont++)
            {
                lbxContas.Items.Add(Lista[Cont].DadosConta());
                lbxContas.Items.Add("Saldo Disp: " + Lista[Cont].SaldoDisp()+ "\t Limite: " + Conta.limite);
                lbxContas.Items.Add("--------------------------------------");
            }
        }

        public void AddConta(Conta[] Lista, int Numero, double Saldo, double Limite)
        {
            Lista[this.TamLista].GravaConta(Numero, Saldo, Limite);
            this.TamLista++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InicializaLista(ListaContas);
            this.AddConta(this.ListaContas, 1234, 1000,500);
            this.AddConta(this.ListaContas, 5678, 2000, 250);
            this.MostraContas(this.ListaContas);
        }

        private void btn_Contas_Click(object sender, EventArgs e)
        {
            this.MostraContas(this.ListaContas);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {            
            lbxContas.Items.Clear();
        }

        private void lbxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            this.ApagaContas(this.ListaContas);
            lbxContas.Items.Clear();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.AddConta(this.ListaContas, Convert.ToInt32(tb_Conta.Text), Convert.ToDouble(tb_Saldo.Text), Convert.ToDouble(tb_Limite.Text));
            this.MostraContas(this.ListaContas);
            this.MostraContas(tb_Saldo.Text.(Saldo = Convert.ToDouble(tb_Saldo.Text)));
        }

        private void btn_Limite_Click(object sender, EventArgs e)
        {
            
        }
    }
}
