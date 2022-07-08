using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificacao.Modelo
{
    class LinhaCompra
    {
        string Descricao;
        internal int Valor;

        public LinhaCompra(string descricao, int valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Valor}€ {Descricao}";
        }
    }
}

