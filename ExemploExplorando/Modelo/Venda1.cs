using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Modelo
{
    public class Venda1
    {
        public int Id { get; set; }

        //Reconhecendo um atributo do arquivo .Json com nome diferente (Adiciona uma metadata)
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}