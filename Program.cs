using System.Security.Cryptography.X509Certificates;

namespace Gerenciamento_Funcionarios
{
    public class Program
    {
        static void Main(string[] args)
        {

                Grenciamento gerenciamento = new Grenciamento();

                while (true)
                {
                    Console.WriteLine("===== CADASTROS E LISTA DE FUNCIONARIOS =====");
                    Console.WriteLine("Escolha a opcao de desejada");
                    Console.WriteLine();
                    Console.WriteLine("1- Cadastrar funcionario");
                    Console.WriteLine("2- Lista de funcionarios");
                    Console.WriteLine();
                    Console.WriteLine("Digite a sua opcao desejada");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            gerenciamento.MenuCadastro();
                            break;
                        case 2:
                            gerenciamento.ListaFuncionario();
                            break;
                        case 3:
                            Console.WriteLine("Digite uma opcao entre 1 e 2");
                            gerenciamento.ComandosLimparTela();
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            
        }
    }
}
