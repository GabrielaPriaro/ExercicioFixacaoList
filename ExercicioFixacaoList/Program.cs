using System.Globalization;

namespace ExercicioFixacaoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.Write("Quantos funcionarios serao registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nFuncionario #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nDigite o ID do funcionario que deseja aumentar o salario: ");
            int idAumentoSalario = int.Parse(Console.ReadLine());

            Funcionario funcionarioAumento = listaFuncionarios.Find(f => f.Id == idAumentoSalario);

            if (funcionarioAumento == null)
            {
                Console.WriteLine("Id digitado nao existe");
            }
            else
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarioAumento.AdicionarAumento(porcentagem);
            }

            Console.WriteLine("\nLista atualizada de funcionarios:");
            ImprimirListaFuncionarios(listaFuncionarios);
        }

        private static void ImprimirListaFuncionarios(List<Funcionario> funcionarios)
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }
    }
}
