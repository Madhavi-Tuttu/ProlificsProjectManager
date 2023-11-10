
using PPM.Domain;
using PPM.Model;

namespace PPM.UI
{
    public class RoleUI
    {
        Role role=new Role();
        RoleDomain roleDomain = new RoleDomain();
        public void AddRole()
        {
            Role role = new Role();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**Add Role**-----------------");
        ridlabel:
            Console.WriteLine("Enter role Id");
            int rId = int.Parse(Console.ReadLine());

            if (!roleDomain.RoleId(rId))
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered Id is already exists");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Id again");
                goto ridlabel;
            }
            role.RoleId = rId;
            Console.WriteLine("Enter Role name");
            role.RoleName = Console.ReadLine();

            roleDomain.Add(role);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nRole Details are added to the list");

        }
        public void ViewAllRoles()
        {
            if (roleDomain.CheckRoleList())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Displaying roles List");
                //for loop to retrieve roles from list
                Console.ForegroundColor = ConsoleColor.White;
                foreach (Role r in RoleDomain.RoleList)
                {
                    Console.WriteLine("\n{0},{1}", r.RoleId, r.RoleName);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Role List is Empty .Add Role to view");
            }
        }
        public void ViewRoleById()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**View Role By Id**-----------------");
            Console.ForegroundColor = ConsoleColor.Green;
        roleid:
            Console.WriteLine("Enter Role Id to view Role by Id");
            int roleid = int.Parse(Console.ReadLine());

            if (roleDomain.CheckId(roleid))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Displaying Role List By Id");
                var Getrole = roleDomain.GetById(roleid);
                if (Getrole != null)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n{0},{1}", Getrole.RoleId, Getrole.RoleName);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Entered Role Id is not exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter exist Role Id");
                goto roleid;
            }
        }
        public void DeleteRole()
        {
            EmployeeUI employeeUI = new();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------**Delete Role**-----------------");
            Console.ForegroundColor = ConsoleColor.Green;
        roleid:
            Console.WriteLine("Enter Role Id to delete Role from Rolelist");
            int roleid = int.Parse(Console.ReadLine());

            if (roleDomain.CheckId(roleid))
            {
                if (!roleDomain.IsRoleMappedToEmployee(roleid))
                {
                    roleDomain.Delete(roleid);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nRole with RoleId {0} is removed from Role list", roleid);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Role is added to employee,Can't remove role from list");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To remove role,first remove role from employee list");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    // Console.WriteLine("Do you want to remove role from employee(Yes/No)");
                    // string status = Console.ReadLine();

                    // if (string.Equals(status, "Yes", StringComparison.OrdinalIgnoreCase))
                    // {
                    //     Console.ForegroundColor = ConsoleColor.Green;
                    //     employeeUI.DeleteEmployee();
                    //     goto roleid;
                    // }
                    
                }
            }
            else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Entered Role Id is not exist");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter exist Role Id");
                    goto roleid;
                }
            }
        }
    }