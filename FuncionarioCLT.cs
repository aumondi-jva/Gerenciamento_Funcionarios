namespace Gerenciamento_Funcionarios
{
    public class FuncionarioCLT : Funcionario, IBeneficios
    {
        public FuncionarioCLT(string nomefunc, string cpf, decimal salario)
        {
            Nome =  nomefunc;
            CPF = cpf;
            Salario = salario;
        }

        public decimal ValeTransporte {  get; set; }
        public decimal ValeRefeicao { get; set; }

        public override decimal CalcularSalario()
        {
            return Salario;
        }

        public decimal CalcularBeneficios()
        {
            return ValeTransporte + ValeRefeicao;
        }

    }
}
