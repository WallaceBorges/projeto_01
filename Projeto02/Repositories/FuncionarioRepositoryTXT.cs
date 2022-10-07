using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT:FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e local do arquivo
            var path = $"c:\\temp\\Funcionários.txt";

            #endregion

            #region Grava conteudo 
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"ID do funcionário...........:{funcionario.id}");
                streamWriter.WriteLine($"Nome do funcionário.........:{funcionario.nome}");
                streamWriter.WriteLine($"Nascimento do funcionário...:{funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamWriter.WriteLine($"CPF do funcionário..........:{funcionario.Cpf}");
                streamWriter.WriteLine($"Matricula do funcionário....:{funcionario.Matricula}");
                streamWriter.WriteLine($"Admissão do funcionário.....:{funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                streamWriter.WriteLine($"ID do Setor.................:{funcionario.Setor.id}");
                streamWriter.WriteLine($"Setor do funcionário:........{funcionario.Setor.Descricao}");
                streamWriter.WriteLine($"**********************************************************");
            }



            #endregion
        }


    }
}
