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
        static string[] Operador = { "(", ")", "{", "}", ",", ";" }; //ver se a virgula é um operador
        static string[] OperadorRelop = { "<", "<=", "=", "=>", ">", "<>", "&", "||" };
        static string[] OperadorMatop = { "+", "-", "*", "/", };

        public List<Identificador> identificadorList { get; set; }

        public string Entrada(string code)
        {
            try
            {
                int tamanho = code.Length;

                identificadorList = new List<Identificador>();

                int index = 0;
                string token = "";

                while (index < tamanho)
                {
                    string palavra = "";

                    while ((code[index] != ' ') &&
                        (!isOperador(code[index].ToString()) &&
                        (!code[index].Equals('\n')) &&
                        (!isOperadorRelop(code[index].ToString())) &&
                        (!isOperadorMatop(code[index].ToString()))))
                    {
                        palavra += code[index].ToString();
                        index++;
                    }

                    if (isKeywords(palavra))
                    {
                        token += "< " + palavra.ToUpper() + " >";
                    }
                    if (isVar(palavra) && !isKeywords(palavra))
                    {
                        if (repeatWordList(palavra) == "")
                        {
                            Identificador identificador = new Identificador(identificadorList.Count + 1, palavra);
                            identificadorList.Add(identificador);
                            token += "< ID, " + (identificadorList.Count).ToString() + " >";
                        }
                        else
                        {
                            token += repeatWordList(palavra);
                        }

                    }
                    if (isNumber(palavra))
                    {
                        token += "< NUMBER, " + palavra.ToString().ToUpper() + " >";
                    }
                    if (isOperador(code[index].ToString()))
                    {
                        token += "< DELOP, " + code[index].ToString().ToUpper() + " >";
                    }
                    if (isOperadorRelop(code[index].ToString()))
                    {
                        token += "< RELOP, " + code[index].ToString().ToUpper() + " >";
                    }
                    if (isOperadorMatop(code[index].ToString()))
                    {
                        token += "< MATOP, " + code[index].ToString().ToUpper() + " >";
                    }
                    if (code[index].Equals('\n'))
                    {
                        token += '\n';
                    }

                    index++;
                }

                return token;
            }
            catch (Exception e)
            {
                return e.Message + "Erro de Sintaxe";
            }
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

        public bool isVar(string palavra)
        {
            if(!string.IsNullOrEmpty(palavra))
            { 
                if(char.IsLetter(palavra[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool isNumber(string palavra)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                if (char.IsDigit(palavra[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public string repeatWordList(string palavra)
        {
            foreach (var item in identificadorList)
            {
                if (item.Lexema == palavra)
                {
                    return "< ID, " + (item.Posicao).ToString() + " >";
                }
            }
            return "";
        }

    }
}
