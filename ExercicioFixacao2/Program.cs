using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double percentage;

            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            employee.GlossSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {employee.Name}\nSalário R$: {employee.netSalary().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Percentual de aumento: ");
            percentage = double.Parse(Console.ReadLine());

            employee.increaseSalary(percentage);
            
        }
    }
}