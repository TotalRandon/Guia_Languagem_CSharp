using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador02
{
    public partial class ListaUsuarios : Form
    {
        public Usuario[] Lista = new Usuario[5];
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        public ListaUsuarios(Usuario[] Lista) : this()
        {
            this.Lista = Lista;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            if (lbx_Usuarios.Items.Count < 5)
            {
                if (tb_NomeUsuario.Text != "")
                {
                    lbx_Usuarios.Items.Add(tb_NomeUsuario.Text);
                    this.tb_NomeUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Número maximo de usuários é 5!");
            }
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (lbx_Usuarios.SelectedIndex >= 0)
            {
                lbx_Usuarios.Items.RemoveAt(lbx_Usuarios.SelectedIndex);
            }
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            int cont;
            for (cont = 0; cont <= 4; cont++)
            {
                if (this.Lista[cont].Nome != "")
                {
                    lbx_Usuarios.Items.Add(this.Lista[cont].ConsultarNome());
                }
            }
        }
        private void ListaUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            int cont;

            //Clear All
            for (cont = 0; cont <= 4; cont++)
            {
                this.Lista[cont].GravarNome("");
            }

            //Grava
            for (cont = 0; cont <= lbx_Usuarios.Items.Count; cont++)
            {
                this.Lista[cont].GravarNome(lbx_Usuarios.Items[cont].ToString());
            }
        }

        private void btnClosehere_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

