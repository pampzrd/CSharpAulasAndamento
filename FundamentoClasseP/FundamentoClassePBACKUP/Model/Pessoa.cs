using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentoClasseP.Model
{
    public class Pessoa
    {
        public string? Nome { get; set; }//A interrogação para strings nulas significa que o valor não é obrigatório.
        public int Idade { get; set; }
        public void Apresentar()
        {
            
            Console.WriteLine($"Meu nome é {Nome} \n e tenho {Idade} anos.");
        
        }
    }
}
