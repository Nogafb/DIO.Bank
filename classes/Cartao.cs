using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Bank
{
    public class Cartao
    {
        private TipoCartao TipoCartao { get; set; }
        private int FinalCartao { get; set; }
        private int NumeroConta { get; set; }


        public Cartao(TipoCartao tipoCartao, int finalCartao, int numeroConta)
         {
            this.TipoCartao = tipoCartao;
            this.FinalCartao = finalCartao;
            this.NumeroConta = numeroConta;
         }

    

    }

    
}
