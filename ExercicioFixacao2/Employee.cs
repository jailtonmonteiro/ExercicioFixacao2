using System.Globalization;

namespace ExercicioFixacao2
{
    internal class Employee
    {
        string name;
        double glossSalary, tax;

        public double netSalary(){
            return (glossSalary - tax);
        }
        public void increaseSalary(double percentage){
            double salary;

            salary = (glossSalary + (glossSalary * percentage / 100)) - tax;
            Console.Write($"Salário Atualizado R$: {salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public string Name 
        {
            get { return name; }
            set { name = value;}
        }
        public double GlossSalary 
        {
            get { return glossSalary; }
            set { glossSalary = value; }
        }
        public double Tax 
        {
            get { return tax; }
            set { tax = value; }
        }
    }
}
