namespace RegisterEmployees {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employees: ");
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < count; i++) {
                Console.WriteLine($"Employee #{i+1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add(new Employee(name, id, salary));
            }
            Console.Write("Enter the employee ID to increase salary: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());
            Employee employee = employees.Find(x => x.Id == idIncrease);
            if (employee != null) {
                employee.Increase(percentage);
            }
            else {
                Console.WriteLine("Employee not found");
            }
            Console.WriteLine("Update list of employees: ");
            foreach (Employee obj in employees) {
                Console.WriteLine(obj.Id + ", "+ obj.Name + ", " + obj.Salary);
            }
        }
    }
}
