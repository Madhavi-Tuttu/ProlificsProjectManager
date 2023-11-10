using System.Xml.Serialization;
using PPM.Domain;

namespace PPM.UI
{


    public class MainMethod
    {
        public void MainTitle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------**********************-------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Prolifics Project Management");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------**********************-------------------");
        }


        public void MethodCall()
        {
            ProjectUI projectUI = new ProjectUI();
            EmployeeUI employeeUI = new EmployeeUI();
            RoleUI roleUI = new RoleUI();
            SerializeData serialdata=new SerializeData();

            bool result = true;

            do
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nChoose the required option");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------View Menu Options-------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1.Project Module");
                Console.WriteLine("2.Employee Module ");
                Console.WriteLine("3.Role Module");
                Console.WriteLine("4.SaveApp");
                Console.WriteLine("5.Exit the system");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--------------------------------------------------");
                int SelectedOption = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEnter the option");
                SelectedOption = int.Parse(Console.ReadLine());

                switch (SelectedOption)
                {

                    case 1:
                        bool ProjectReturn = true;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-----------------Project Module----------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nChoose the required option");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-----------------View Menu Options-------------");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("1.Add Project");
                            Console.WriteLine("2.List All Projects");
                            Console.WriteLine("3.List Project By Id");
                            Console.WriteLine("4.Delete Project");
                            Console.WriteLine("5.Add Employee to Project ");
                            Console.WriteLine("6.View Employee Details who added to Project");
                            Console.WriteLine("7.Delete Employee from Project ");
                            Console.WriteLine("8.Return to Main Menu");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-----------------------------------------------");
                            int Poption = 0;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nEnter the option");
                            Poption = int.Parse(Console.ReadLine());
                            switch (Poption)
                            {
                                case 1:
                                    projectUI.AddProject();
                                    break;
                                case 2:
                                    projectUI.ViewAllProjects();
                                    break;
                                case 3:
                                    projectUI.ViewProjectById();
                                    break;
                                case 4:
                                    projectUI.DeleteProject();
                                    break;
                                 case 5:
                                    projectUI.AddEmployeeToProject();
                                    break;
                                 case 6:
                                    projectUI.ViewProjectDetails();
                                    break;
                                case 7:
                                    projectUI.DeleteEmployeeFromProject();
                                    break;
                                case 8:
                                    ProjectReturn = false;
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("\nEnter any key to Exit");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nSelect Valid Option");
                                    break;
                            }
                        } while (ProjectReturn != false);


                        break;
                    case 2:
                        bool EmployeeReturn= true;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-----------------Employee Module----------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nChoose the required option");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-----------------View Menu Options-------------");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("1.Add Employee");
                            Console.WriteLine("2.List All Employees");
                            Console.WriteLine("3.List Employee By Id");
                            Console.WriteLine("4.Delete Employee");
                            Console.WriteLine("5.Return to Main Menu");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("--------------------------------------------------");
                            int Poption = 0;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nEnter the option");
                            Poption = int.Parse(Console.ReadLine());
                            switch (Poption)
                            {
                                case 1:
                                    employeeUI.AddEmployee();
                                    break;
                                case 2:
                                    employeeUI.ViewAllEmployees();
                                    break;
                                case 3:
                                    employeeUI.ViewEmployeeById();
                                    break;
                                case 4:
                                    employeeUI.DeleteEmployee();
                                    break;
                                case 5:
                                   EmployeeReturn = false;
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("\nEnter any key to Exit");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nSelect Valid Option");
                                    break;
                            }
                        } while (EmployeeReturn != false);

                        break;
                    case 3:
                       bool RoleReturn = true;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("-----------------Project Module----------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nChoose the required option");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-----------------View Menu Options-------------");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("1.Add Role");
                            Console.WriteLine("2.List All Roles");
                            Console.WriteLine("3.List Role By Id");
                            Console.WriteLine("4.Delete Role");
                            Console.WriteLine("5.Return to Main Menu");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("--------------------------------------------------");
                            int Poption = 0;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nEnter the option");
                            Poption = int.Parse(Console.ReadLine());
                            switch (Poption)
                            {
                                case 1:
                                    roleUI.AddRole();
                                    break;
                                case 2:
                                    roleUI.ViewAllRoles();
                                    break;
                                case 3:
                                    roleUI.ViewRoleById();
                                    break;
                                case 4:
                                    roleUI.DeleteRole();
                                    break;
                                case 5:
                                    RoleReturn = false;
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("\nEnter any key to Exit");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nSelect Valid Option");
                                    break;
                            }
                        } while (RoleReturn != false);

                        break;
                    case 4:
                        serialdata.SaveState();
                        break;
                    case 5:
                        result = false;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nEnter any key to Exit");
                        Console.ReadLine();
                        break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please Enter valid option");
                        break;

                }
            } while (result != false);

        }
    }
}