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
    public partial class FRM_Visualizador : Form
    {
        public Usuario[] Lista = new Usuario[5];
        public FRM_Visualizador()
        {
            InitializeComponent();
        }

        public void InicalizaLista(Usuario[] Lista)
        {
            int cont;
            for(cont = 0; cont <= 4; cont ++)
            {
                Lista[cont] = new Usuario();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Selecionar_Click(object sender, EventArgs e)
        {
            //Mostra a janela de seleção de arquivos.
            if (ofd_SelFigura.ShowDialog() == DialogResult.OK)
            {
                // Carrega a figura em pb_Figura
                pb_figura.Image = Image.FromFile(ofd_SelFigura.FileName);

                // Mostra o nome do arquivo no título do formulário.
                this.Text = string.Concat("Visualizador (" + ofd_SelFigura.FileName + ")");
            }


        }

        private void FRM_Visualizador_Load(object sender, EventArgs e)
        {
            this.InicalizaLista(this.Lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height += 20;
            this.Width += 20;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Height -= 20;
            this.Width -= 20;
        }

        private void btn_Borda_Click(object sender, EventArgs e)
        {
            Graphics Graph = null;

            Graph = this.CreateGraphics();
            Graph.Clear(SystemColors.Control);
            Graph.DrawRectangle(Pens.Red, pb_figura.Left+1, pb_figura.Top+1,
                pb_figura.Width+1, pb_figura.Height+1);

            Graph.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)//lixo
        {
            
        }

        private void labY_Click(object sender, EventArgs e)//lixo
        {

        }

        private void pb_figura_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X;
            lblY.Text = "Y: " + e.Y;
        }

        private void btn_Abrir_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Opcoes frmOpcoes = new frm_Opcoes();
            frmOpcoes.ShowDialog();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {

        }

        private void btnListaInicio_Click(object sender, EventArgs e)
        {
            ListsForm lists = new ListsForm();
            lists.ShowDialog();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios L = new ListaUsuarios(this.Lista);
            L.Show();
        }
    }
}
