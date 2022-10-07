using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Pessoa
    {
        #region MyRegion
        public Guid id { get; set; }
        public string nome { get; set; }
        public DateTime DataNascimento { get; set; }    
        #endregion


    }
}
