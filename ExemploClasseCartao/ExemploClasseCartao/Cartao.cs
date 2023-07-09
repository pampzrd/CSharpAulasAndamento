using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseCartao
{
    public class Cartao
    {
        public string NomeProprietario { get; set; }
        public string Numero { get; set; }
        public int Digito { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public bool Ativo { get; set; }
        public DateTime Validade { get; set; }

        //incluindo os enums
        public NomeBanco Banco { get; set; }
        public TipoCartao Tipo { get; set; }

    }
}
