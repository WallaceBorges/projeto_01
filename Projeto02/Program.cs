using Projeto02.Controllers;

namespace Projeto02
{
    public class program
    {
        public static void Main(string [] args)
        {
            var funcionarioController = new FuncionarioController();
            funcionarioController.CadastrarFuncionario();
            
            funcionarioController.PrintFuncionario();

        /*  Console.Write(" Deseja cadastrar novo?(1-Sim  2-Não)");
          var Console.ReadLine()*/
            


        }
    }
}