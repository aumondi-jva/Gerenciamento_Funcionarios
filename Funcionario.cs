namespace Gerenciamento_Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome {  get; set; }
        public string CPF { get; set; }
        public decimal Salario { get; set; }

        public abstract decimal CalcularSalario();

    }
}
