using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Repositories;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        Funcionario funcionario1=new Funcionario();
        #region Metodos
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n****Cadastro de Funcionários****");
                #region Captura Funcionário
                var funcionario = new Funcionario();
                funcionario.id=Guid.NewGuid();
                Console.Write("Nome do Funcionario: ");
                funcionario.nome = Console.ReadLine();

                Console.Write("Data de Nascimento: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("CPF do funcionário: ");
                funcionario.Cpf=Console.ReadLine();

                Console.Write("Matricula do Funcionário: ");
                funcionario.Matricula= Console.ReadLine();

                Console.Write("Data de Admissão: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                funcionario.Setor = new Setor();
                funcionario.Setor.id=Guid.NewGuid();

                Console.Write("Sigla do Setor: ");
                funcionario.Setor.Sigla=Console.ReadLine();
                Console.Write("Descrição do Setor: ");
                funcionario.Setor.Descricao=Console.ReadLine();

                funcionario1 = funcionario;
                Console.ReadKey();
                #endregion

                #region exporta
                Console.Write("\nInforme (1) CSV ou (2)Txt: ");
                var opcao = int.Parse(Console.ReadLine());
                FuncionarioRepository funcionarioRepository = null;
                switch (opcao)
                {
                    case 1:
                        funcionarioRepository = new FuncionarioRepositoryCSV();
                       
                        break;
                    case 2:
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                       
                        break;
                    default:
                        Console.WriteLine("\nFormato Invalido!!! ");
                        break;

                }
                if (funcionarioRepository != null)
                {
                    funcionarioRepository.ExportarDados(funcionario1);
                    Console.WriteLine("\nDados gravados com sucesso!");
                }
     

                #endregion
            }
            catch (Exception e)
            {

                Console.WriteLine($"\nFalha {e.Message}");
            }
        }
        #endregion
        #region Print Funcionario
        public void PrintFuncionario()
        {
            

            Console.WriteLine("\n******Dados*****\n");
            Console.WriteLine($"Funcionário é {funcionario1.nome}");
            Console.WriteLine($"Nascido em {funcionario1.DataNascimento}");
            Console.WriteLine($"Com o CPF {funcionario1.Cpf}");
            Console.WriteLine($"Admitido em {funcionario1.DataAdmissao}");
            Console.WriteLine($"Matriculado com a Matricula {funcionario1.Matricula}");
            Console.WriteLine($"Pertence ao Setor {funcionario1.Setor.Descricao}" +
                $"({funcionario1.Setor.Sigla}) ID= {funcionario1.Setor.id}");
            Console.ReadKey();


           
        }
        #endregion

    }
}
