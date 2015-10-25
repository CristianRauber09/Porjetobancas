using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTCC.core
{
    public class Semestre : Ipessoa
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Semestre(int pId, string pNome)
        {
            id = pId;
            nome = pNome;
        }
    }
}