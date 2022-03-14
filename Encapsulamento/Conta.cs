using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public class Conta
    {
        private int numero;
        private double saldo;
        private static double limite;

        private int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        private double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if(value < 0)
                {
                    
                }
                else
                {
                    this.saldo = value;
                }
            }
        }

        private double Limite
        {
            get
            {
                return Conta.limite;
            }
            set
            {
                Conta.limite = value;
            }
        }

        private Conta(int Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            Conta.limite = Limite;
        }

        private static void GravarLimite(double Valor)
        {
            
        }

        private void GravaConta(int Numero, double Saldo, double Limite)
        {
            this.Numero = Numero;
            this.Saldo = Saldo;
            Conta.limite = Limite;
        }

        private string DadosConta()
        {
            return "Conta: " + this.Numero + "\t Saldo: " + this.Saldo;
        }

        private double SaldoDisp()
        {
            return (this.Saldo + Conta.limite);
        }
    }

    /*
    public static class Controle
    {
        public static double GravarLimite(double limite)
        {
            return limite;
        }
        

    }
       
    */
}


/* 
 
        public double Limite()
        {
            return limite;
        }

*/
