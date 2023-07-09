using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseCartao
{
    public class ServicosCartao
    {
        private Cartao Cartao { get; set; }

        public ServicosCartao(Cartao cartao) //Construtor (ctor)
        {
            Cartao = cartao;
        }
        //Métodos abaixo
        public void AtivarCartao()
        {
            Cartao.Ativo = true;
        }

        public void DesativarCartao()
        {
            Cartao.Ativo = false;
        }

        public decimal VerificarSaldo()
        {
            //VerificarNumeroCartao() só é visto pela própria classe, não fora, pq é privado.
            return Cartao.Saldo;
        }

        public void Retirar(decimal valor)
        {
             Cartao.Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
             Cartao.Saldo += valor;
        }

        private string VerificarNumeroCartao()
        {
            return Cartao.Numero;
        }

    }
}
