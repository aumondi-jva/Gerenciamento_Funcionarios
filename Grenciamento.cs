using System.Runtime.InteropServices;

namespace Gerenciamento_Funcionarios
{
    public class Grenciamento
    {
        List<Funcionario> listafuncionarios = new List<Funcionario>();
        public void CadastrarCLT()
        {
            Console.Clear();

            Console.Write("Informe o nome do funcionario CLT: ");
            string nomeclt = Console.ReadLine();
            Console.Write("Informe o CPF do funcionario CLT: ");
            string cpfclt = Console.ReadLine();
            Console.Write("Informe o salario do funcionario CLT: ");
            decimal salarioclt = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o valor do vale transporte: ");
            decimal valetranspclt = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o valor do vale refeição: ");
            decimal valerefclt = Convert.ToDecimal(Console.ReadLine());

            FuncionarioCLT funcCLT = new FuncionarioCLT(nomeclt, cpfclt, salarioclt);
            funcCLT.ValeTransporte = valetranspclt;
            funcCLT.ValeRefeicao = valerefclt;
            funcCLT.CalcularBeneficios();
            listafuncionarios.Add(funcCLT);

            Console.Clear();
            Console.WriteLine("Funcionário cadastrado com sucesso !");

            ComandosLimparTela();

        }

        public void CadastrarPJ()
        {
            Console.Clear();

            Console.Write("Informe o nome do funcionario PJ: ");
            string nomepj = Console.ReadLine();
            Console.Write("Informe o CPF do funcionario PJ: ");
            string cpfpj = Console.ReadLine();
            Console.Write("Informe a quantidade de horas no mes trabalhadas: ");
            int horastrabalhadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor da hora trabalhada: ");
            decimal valorhora = Convert.ToDecimal(Console.ReadLine());

            FuncionarioPJ funcPJ = new FuncionarioPJ(nomepj, cpfpj);
            funcPJ.HorasTrabalhadas = horastrabalhadas;
            funcPJ.ValorHora = valorhora;
            funcPJ.CalcularSalario();
            listafuncionarios.Add(funcPJ);

            Console.Clear();
            Console.WriteLine("Funcionário cadastrado com sucesso !");

            ComandosLimparTela();

        }

        public void CadastrarEstagiario()
        {
            Console.Clear();

            Console.Write("Informe o nome do estagiario: ");
            string nomeestagiario = Console.ReadLine();
            Console.Write("Informe o CPF do estagiario: ");
            string cpfestagiario = Console.ReadLine();
            Console.Write("Informe o salario do estagiario: ");
            decimal salarioestagiario = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o valor do vale transporte: ");
            decimal valetranspestagiario = Convert.ToDecimal(Console.ReadLine());

            Estagiario estagiario = new Estagiario(nomeestagiario, cpfestagiario, salarioestagiario);
            estagiario.ValeTransporte = valetranspestagiario;
            estagiario.CalcularBeneficios();
            listafuncionarios.Add(estagiario);

            Console.Clear();
            Console.WriteLine("Funcionário cadastrado com sucesso !");

            ComandosLimparTela();
        }

        public void ListaFuncionario()
        {
            Console.Clear();

            foreach (Funcionario func in listafuncionarios)
            {
                Console.WriteLine();
                Console.WriteLine($"Nome: {func.Nome}");
                Console.WriteLine($"CPF: {func.CPF}");
                Console.WriteLine($"Salario: {func.CalcularSalario()}");

                if (func is IBeneficios beneficio)
                {
                    Console.WriteLine($"Benenficio: {beneficio.CalcularBeneficios()}");
                }
            }

            ComandosLimparTela();

        }

        public void ComandosLimparTela()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public void MenuCadastro()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTROS FUNCIONARIOS =====");
                Console.WriteLine("Escolha o tipo de funcionario desejado");
                Console.WriteLine();
                Console.WriteLine("1- Cadastrar CLT");
                Console.WriteLine("2- Cadastrar PJ");
                Console.WriteLine("3- Cadastrar ESTAGIARIO");
                Console.WriteLine();
                Console.WriteLine("Digite a sua opcao desejada");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCLT();
                        return;
                    case 2:
                        CadastrarPJ();
                        return;
                    case 3:
                        CadastrarEstagiario();
                        return;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite uma opção entre 1 a 3");
                        ComandosLimparTela();
                        return;
                    default:
                        Console.Clear();
                        return;
                       
                }
            }
        }
    }
}
