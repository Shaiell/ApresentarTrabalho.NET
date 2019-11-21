using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class EstoqueEntrada : Estoque
    {
        public EstoqueEntrada()
        {
            this.DataEntrada = DateTime.Now;
        }

    }
}
