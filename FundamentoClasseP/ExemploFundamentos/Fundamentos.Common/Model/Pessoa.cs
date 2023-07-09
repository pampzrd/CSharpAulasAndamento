using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Common.Model
{
    
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }//A interrogação para strings nulas significa que o valor não é obrigatório.
        public int Idade { get; set; }

        ///<summary>
        ///Apresentação com nome e idade
        /// </summary>
        public void Apresentar()
        {
            
            Console.WriteLine($"Meu nome é {Nome} \n e tenho {Idade} anos.");
        
        }
    }
}
