namespace Gerenciamento_Funcionarios
{
    public class FuncionarioPJ : Funcionario
    {
        public FuncionarioPJ(string nomefunc, string cpf)
        {
            Nome = nomefunc;
            CPF = cpf;
        }

        public int HorasTrabalhadas { get; set; }
        public decimal ValorHora { get; set; }

        public override decimal CalcularSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }

        public FuncionarioPJ() { }
    }
}
