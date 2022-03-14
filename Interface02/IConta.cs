using System;
using System.Collections.Generic;
using System.Text;

namespace Interface02
{
    interface IConta
    {
        void Deposita(double valor);
        void Saca(double valor);
        double Saldo { get; set; }
    }
}
