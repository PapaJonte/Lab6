namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates 5 Employee objects using the properties from the Employee class
            Employee employee1 = new Employee
            {
                Id = 1,
                Name = "Håkan",
                Gender = "Male",
                Salary = 50000m
            };
            Employee employee2 = new Employee
            {
                Id = 2,
                Name = "Anna",
                Gender = "Female",
                Salary = 35000m
            };
            Employee employee3 = new Employee
            {
                Id = 3,
                Name = "Maria",
                Gender = "Female",
                Salary = 28000m
            };
            Employee employee4 = new Employee
            {
                Id = 4,
                Name = "Anders",
                Gender = "Male",
                Salary = 27000m
            };
            Employee employee5 = new Employee
            {
                Id = 5,
                Name = "Tobias",
                Gender = "Male",
                Salary = 25000m
            };

            //
            // PART 1
            //

            // Adds the Employee objects to a stack
            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            // Using a foreach loop top type out all the employees along with amount of items left in the stack
            Console.WriteLine("PART 1");
            Console.WriteLine();
            Console.WriteLine("Employee stack:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}kr");
                Console.WriteLine($"Items left in stack: {employees.Count}");
            }
            Console.WriteLine("-----------------------------");

            // Using Pop method to remove one employee at a time, while printing them all out and how many items left in the stack
            Console.WriteLine("Retrieve using Pop method");
            while (employees.Count > 0)
            {
                Employee removedEmployee = employees.Pop();
                Console.WriteLine($"{removedEmployee.Id} - {removedEmployee.Name} - {removedEmployee.Gender} - {removedEmployee.Salary}kr");
                Console.WriteLine($"Items left in stack: {employees.Count}");
            }
            Console.WriteLine("-----------------------------");

            // Add all employees back to the stack
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            // Using Peek method to retrieve 2 objects. Since we don't use Pop in between, it will show the same object twice (the object at the top of the stack)
            Console.WriteLine("Retrieve using Peek method:");
            Employee firstPeek = employees.Peek();
            Console.WriteLine($"{firstPeek.Id} - {firstPeek.Name} - {firstPeek.Gender} - {firstPeek.Salary}kr");
            Console.WriteLine($"Items left in stack: {employees.Count}");
            Employee secondPeek = employees.Peek();
            Console.WriteLine($"{secondPeek.Id} - {secondPeek.Name} - {secondPeek.Gender} - {secondPeek.Salary}kr");
            Console.WriteLine($"Items left in stack: {employees.Count}");
            Console.WriteLine("-----------------------------");

            // Check if the stack contains object 3 and print out the result
            if (employees.Contains(employee3))
            {
                Console.WriteLine("Object number 3 exists in the stack");
            }
            else
            {
                Console.WriteLine("Object number 3 doesn't exist in the stack");
            }


            //
            // PART 2
            //

            // Adds all the Employee objects to our list
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            Console.WriteLine();
            Console.WriteLine("PART 2");
            Console.WriteLine();

            // Check if the list contains object 2 and print out the result
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("Object number 2 exists in the list");
            }
            else
            {
                Console.WriteLine("Object number 2 doesn't exist in the list");
            }
            Console.WriteLine();
            // Use the Find method to find the first object in the list with "Male" in their Gender property and prints out the result
            Employee? foundEmployee = employeeList.Find(e => e.Gender == "Male");
            if (foundEmployee != null)
            {
                Console.WriteLine($"{foundEmployee.Id} - {foundEmployee.Name} - {foundEmployee.Gender} - {foundEmployee.Salary}kr");
            }
            else
            {
                Console.WriteLine("There exists no male employees at this company!");
            }
            Console.WriteLine();

            // Use the FindAll method to find all objects in the list with "Male" in their Gender property and prints out the result
            List<Employee> foundEmployees = employeeList.FindAll(e => e.Gender == "Male");
            if (foundEmployees.Count > 0)
            {
                foreach (Employee employee in foundEmployees)
                {
                    Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}kr");
                }
            }
            else
            {
                Console.WriteLine("There exists no male employees at this company!");
            }
        }
    }
}
