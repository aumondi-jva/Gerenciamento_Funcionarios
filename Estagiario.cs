namespace Gerenciamento_Funcionarios
{
    public class Estagiario : Funcionario, IBeneficios
    {
        public decimal ValeTransporte { get; set; }

        public override decimal CalcularSalario()
        {
            return Salario;
        }

        public decimal CalcularBeneficios()
        {
            return ValeTransporte;
        }

        public Estagiario(string nomeestagiario, string cpfestagiario, decimal salarioestagiario)
        {
            Nome = nomeestagiario;
            CPF = cpfestagiario;
            Salario = salarioestagiario;
        }

        public Estagiario() { }
    }
}
