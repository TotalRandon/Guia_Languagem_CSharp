using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador02
{
    public class Usuario
    {
        public string Nome;

        public Usuario()
        {
            this.Nome = "";
        }

        public Usuario(String Nome)
        {
            this.Nome = Nome;
        }

        public void GravarNome(String Nome)
        {
            this.Nome = Nome;
        }

        public String ConsultarNome()
        {
            return this.Nome;
        }
    }
}
