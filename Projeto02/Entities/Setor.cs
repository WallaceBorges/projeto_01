using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Setor
    {
        #region MyRegion
        public Guid id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        #endregion

        #region Associacoes
        public List<Funcionario> funcionarios { get; set; }

        #endregion

    }
}
