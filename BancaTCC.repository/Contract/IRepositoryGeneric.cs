using BancaTCC.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaTCC.repository
{
    public interface IRepositoryGeneric<Tentity> where Tentity : class
    {


        void Create(Tentity tentity);
        void Update(Tentity tentity);
        void Delete(int pId);
        IEnumerable<Tentity> GetAll();
        object GetOne(int pId);
        
    }
}
