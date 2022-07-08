using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificacao.Modelo
{
    class Compra
    {
        DateTime DataHora;
        internal int Total;
        internal List<LinhaCompra> LinhasCompra;

        public Compra(DateTime dataHora)
        {
            DataHora = dataHora;
            Total = 0;
            LinhasCompra = new List<LinhaCompra>();
        }

        public void AdicionarLinha(LinhaCompra linha)
        {
            LinhasCompra.Add(linha);
            Total += linha.Valor;
        }

        public void RemoverLinha(LinhaCompra linha)
        {
            LinhasCompra.Remove(linha);
        }

        public int CalcularTotais()
        {
            int total = 0;
            foreach (var linha in this.LinhasCompra)
            {
                total += linha.Valor;
            }
            return total;
        }

        public override string ToString()
        {
            return $"{DataHora.ToString("dd/MM/yyyy HH:mm:ss")} | {Total} €";
        }
    }
}

    

    



