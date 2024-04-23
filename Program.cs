namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> EmployeeList = new List<Employee>();
            {
                new Employee() { EmpId = 1, Name = "Sathwik", Gender = "Male", Salary = 45000 };
                new Employee() { EmpId = 4, Name = "Bhargav", Gender = "Male", Salary = 40000 };
                new Employee() { EmpId = 2, Name = "Dharani", Gender = "Female", Salary = 35000 };
                new Employee() { EmpId = 3, Name = "Mansoor", Gender = "Male", Salary = 45000 };
            };

            List<Employee> employees = new List<Employee>();
            {
                Employee emp1  = new Employee() { EmpId = 1, Name = "Sathwik", Gender = "Male", Salary = 45000 };
                Employee emp2  = new Employee() { EmpId = 4, Name = "Bhargav", Gender = "Male", Salary = 40000 };
                Employee emp3  = new Employee() { EmpId = 2, Name = "Dharani", Gender = "Female", Salary = 35000 };
                Employee emp4  = new Employee() { EmpId = 3, Name = "Mansoor", Gender = "Male", Salary = 45000 };
            }

            var MaleEmployees = employees.Where(emp => emp.Gender == "Male").ToList();

            Console.WriteLine( " \n \n Male Employees");
            List<Employee> MaleEmployeeList = new List<Employee>();
            foreach (Employee emp in MaleEmployees)
            {
                if(emp .Gender =="Male")
                { 
                    Console.WriteLine( emp.Name );
                }
                if (emp.Gender == "Female")
                {
                    Console.WriteLine($"{emp.EmpId}\t {emp.Name}\t {emp.Gender}\t {emp.Salary} ");
                }
                Console.ReadLine();
            }

        }
        class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set;}
        }
    }
}
