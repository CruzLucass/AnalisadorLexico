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
        static string[] OperadorRelop = { "<", "<=", "=", "=>", ">", "<>", "&", "||" };
        static string[] OperadorMatop = { "+", "-", "*", "/", };
        
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
            while (index < tamanho)
            {
                string palavra = "";

                while( (code[index] != ' ') && 
                    (!isOperador(code[index].ToString()) && 
                    (!code[index].Equals('\n') ) && 
                    (!isOperadorRelop(code[index].ToString() ) ) && 
                    (!isOperadorMatop(code[index].ToString() ) ) ) )
                {
                    palavra += code[index].ToString();
                    index++;
                }

                if (isKeywords(palavra))
                {
                    token += "< " + palavra.ToUpper() + " >";
                }
                if (isOperador(code[index].ToString()))
                {
                    token += "< DELOP, " + code[index].ToString().ToUpper() + " >";
                }
                if (code[index].Equals('\n'))
                {
                    token += '\n';
                }
                index++;
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

        public bool isOperadorRelop(string palavra)
        {
            foreach (var item in OperadorRelop)
            {
                if (item == palavra)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isOperadorMatop(string palavra)
        {
            foreach (var item in OperadorMatop)
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
