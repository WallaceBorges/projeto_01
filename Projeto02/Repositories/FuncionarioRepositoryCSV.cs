﻿using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryCSV:FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
          
            #region Definindo o nome e local do arquivo
            var path = $"c:\\temp\\Funcionários.csv";

            #endregion

            #region Grava conteudo 
            using (var streamWriter = new StreamWriter(path, true))
            {
                var texto = $"{funcionario.id};" +
                $"{funcionario.nome};" +
                $"{funcionario.DataNascimento.ToString("dd/MM/yyyy")};" +
                $"{funcionario.Cpf};" +
                $"{funcionario.Matricula};" +
                $"{funcionario.DataAdmissao.ToString("dd/MM/yyyy")};" +
                $"{funcionario.Setor.id};" +
                $"{funcionario.Setor.Descricao};";

                streamWriter.WriteLine(texto);
       
            }



            #endregion
        }


   
    }
}