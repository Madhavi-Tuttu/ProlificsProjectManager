
using PPM.Domain;
using PPM.Model;

namespace PPM.UI
{
    public class EmployeeUI
    {
        Employee employee = new Employee();
        EmployeeDomain employeeDomain = new EmployeeDomain();
        RoleDomain roleDomain = new RoleDomain();
        RoleUI roleUI = new RoleUI();
        public void AddEmployee()
        {

            Employee employee = new Employee();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**Add Employee**-----------------");
        eidlabel:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Employee Id");
            int eId = int.Parse(Console.ReadLine());

            //validating employeeid
            if (!employeeDomain.EmployeeId(eId))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered Id is already exists");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Id again");
                goto eidlabel;
            }
            employee.EmployeeId = eId;

            Console.WriteLine("Enter Employee firstName");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Employee lastName");
            employee.LastName = Console.ReadLine();
        emaillabel:
            Console.WriteLine("Enter employee email");
            string email = Console.ReadLine();

            if (!employeeDomain.EmployeeEmail(email))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Invalid email id or Entered email is already exists ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter email again");
                goto emaillabel;
            }

            employee.Email = email;

        numlabel:
            Console.WriteLine("Enter employee mobile number in +91 format");
            string mNum = Console.ReadLine();
            if (!employeeDomain.Employeenum(mNum))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Invalid phone number or Entered phone is already exists ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter phone number again");
                goto numlabel;
            }

            employee.MobileNum = mNum;

            Console.WriteLine("Enter employee address");
            employee.Address = Console.ReadLine();

            if (roleDomain.CheckRoleList())
            {
                goto eridlabel;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Role list is empty ,add role and then add employee to exist role");
                roleUI.AddRole();
            }

        eridlabel:
            Console.WriteLine("Enter Employee role Id");
            int rId = int.Parse(Console.ReadLine());
            //validating roleid
            if (!employeeDomain.EmployeeRoleId(rId))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered Id is not exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter exist Id");
                goto eridlabel;
            }
            employee.EmployeeRoleId = rId;

            employeeDomain.Add(employee);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEmployee Details are added to the list");
        }

        public void ViewAllEmployees()
        {
            if (employeeDomain.CheckEmployeeList())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Displaying employees List");
                //for loop to retrieve employees from list
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Employee e in EmployeeDomain.EmployeeList)
                {
                    Console.WriteLine("\n{0},{1},{2},{3},{4},{5}", e.EmployeeId, e.FirstName, e.LastName, e.Email, e.MobileNum, e.Address, e.EmployeeRoleId);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Employee List is Empty.Add employee to view");
            }
        }
        public void ViewEmployeeById()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**View Employee By Id**-----------------");
            Console.ForegroundColor = ConsoleColor.Green;
        employeeid:
            Console.WriteLine("Enter Employee Id to view Employee by Id");
            int employeeid = int.Parse(Console.ReadLine());

            if (employeeDomain.CheckId(employeeid))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Displaying Employee List By Id");
                var Getemployee = employeeDomain.GetById(employeeid);
                if (Getemployee != null)
                {
                    Console.WriteLine("\n{0},{1},{2},{3}", Getemployee.EmployeeId, Getemployee.FirstName, Getemployee.LastName, Getemployee.Email, Getemployee.MobileNum, Getemployee.Address, Getemployee.EmployeeRoleId);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered employee Id is not exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter exist employee Id");
                goto employeeid;
            }
        }

        public void DeleteEmployee()
        {
            ProjectUI projectUI = new();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**Delete Employee**-----------------");
            Console.ForegroundColor = ConsoleColor.Green;
        employeeid:
            Console.WriteLine("Enter Employee Id to delete employee from Employeelist");
            int employeeid = int.Parse(Console.ReadLine());

            if (employeeDomain.CheckId(employeeid))
            {
                if (!employeeDomain.IsEmployeeMappedToProject(employeeid))
                {
                    employeeDomain.Delete(employeeid);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nEmployee with EmployeeId {0} is removed from Employee list", employeeid);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Employee is added to project,Can't remove employee from list");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To remove employee,first remove employee from Employee to project list");
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    // Console.WriteLine("Do you want to remove employee from project(Yes/No)");
                    // string status = Console.ReadLine();

                    // if (string.Equals(status, "Yes", StringComparison.OrdinalIgnoreCase))
                    // {
                    //     Console.ForegroundColor = ConsoleColor.Green;
                    //     projectUI.DeleteEmployeeFromProject();
                    //     goto employeeid;
                    // }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered employee Id is not exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter exist employee Id");
                goto employeeid;
            }
        }
    }
}
