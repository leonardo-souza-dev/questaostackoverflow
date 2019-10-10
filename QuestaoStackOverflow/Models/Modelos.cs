using System;
using System.Collections.Generic;

namespace QuestaoStackOverflow.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public bool Checado { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; set; }
        public PedidoVenda PedidoVenda { get; set; }
    }

    public class Cliente
    {
        public string Nome { get; set; }
    }

    public class PedidoVenda
    {
        public int EmpresaID { get; set; }
    }

    public class ListaContrato
    {
        public int Id { get; set; }
        public List<Contrato> Contratos { get; set; }

        public ListaContrato()
        {
            Contratos = new List<Contrato>();
        }
    }

    public class EnviarLoteViewModel
    {
        public int[] Ids { get; set; }
    }
}
