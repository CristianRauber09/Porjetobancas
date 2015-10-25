using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancaTCC.core
{
    public class Funcionario : Ipessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
    }
}