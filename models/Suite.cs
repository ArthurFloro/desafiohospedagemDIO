using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafiohospedagem.models
{
    public class Suite
    {
        public String TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public Decimal ValorDiaria { get; set; }

        public Suite(String tipoSuite, int capacidade, Decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}