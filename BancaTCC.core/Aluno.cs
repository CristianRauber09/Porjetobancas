using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTCC.core
{
    public class Aluno : Ipessoa
    {
        public int id { get; set; }
        public string nome { get; set; }


        public Aluno(int pId, string pNome)
        {
            id = pId;
            nome = pNome;
        }
    }
    
}