using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class Identificador
    {
        public int Posicao { get; set; }
        public string Lexema { get; set; }

        public Identificador(int chave, string valor)
        {
            this.Lexema = valor;
            this.Posicao = chave;
        }
    }
}
