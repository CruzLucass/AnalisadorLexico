using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Scanner
    {
        static string[] KeyWords = { "IF", "THEN", "ELSE", "WHILE", "INT", "VOID", "MAIN" };
        static string[] Operador = { "(", ")", "{", "}", ",",  }; //ver se a virgula é um operador
        
        public string Entrada(string code)
        {
            string aux = "";
            int tamanho = 0;
            foreach (var item in code.ToCharArray())
            {
                aux += item;
                tamanho++;
            }
            
            int index = 0;
            string token = "";
            while (tamanho > 0)
            {
                string palavra = "";
                int i = index;
                int j = 0;

                while(!string.IsNullOrWhiteSpace(code[i].ToString()) && !isOperador(code[i].ToString()) )
                {
                    palavra += code[i];
                    i++;
                }
                if (isKeywords(palavra))
                {
                    token +=  "<" + palavra.ToUpper() + " >";
                }
                if (isOperador(palavra))
                {
                    token += "< DELOP, " + palavra.ToUpper() + " >";
                }
                if (code[i] == '\n')
                {
                    token += "\n";
                }

                index++;
                tamanho--;
            }

            return token;
        }

        public bool isKeywords(string palavra)
        {
            foreach (var item in KeyWords)
            {
                if (item == palavra.ToUpper())
                {
                    return true;
                }                
            }
            return false;
        }

        public bool isOperador(string palavra)
        {
            foreach(var item in Operador)
            {
                if (item == palavra)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
