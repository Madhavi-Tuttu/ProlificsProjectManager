using System.Collections.Generic;
using System.Text.RegularExpressions;
using PPM.Model;

namespace PPM.Domain
{
    public class EmployeeDomain
{
    Employee employee=new Employee();
    Project project=new();
    public static List<Employee> EmployeeList =new List<Employee>();
    public bool EmployeeId(int eId)
    {
        var eidexist = EmployeeList.Find(item => item.EmployeeId == eId);
        if (eidexist != null)
        {
            return false;
        }
        return true;
    }

    public bool EmployeeEmail(string email)
    {
        Regex emailRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@#$%^&+=]).{10,}$");
        var emailexist = EmployeeList.SingleOrDefault(item => item.Email == email);

        if (!emailRegex.IsMatch(email) || emailexist != null)
        {
            return false;
        }
        return true;
    }
    public bool Employeenum(string mNum)
    {
        Regex phoneRegex = new Regex(@"^\+(\d{2})\d{10}$");
        var numexist = EmployeeList.SingleOrDefault(item => item.MobileNum == mNum);
        if (!phoneRegex.IsMatch(mNum) || numexist != null)
        {
            return false;
        }
        return true;
    }

    //  public bool RoleExist()
    // {
    //     if (RoleDomain.RoleList.Count == 0)
    //     {
    //         return false;
    //     }
    //     return true;
    // }

    public bool EmployeeRoleId(int rId)
    {
        var ridexist = RoleDomain.RoleList.Find(item => item.RoleId == rId);
        if (ridexist == null)
        {
            return false;
        }
        return true;
    }
    public void Add(Employee employeeDomain)
    {
        //Adding employee details to list
        EmployeeList.Add(employeeDomain);

    }
      public bool CheckEmployeeList()
    {
        if (EmployeeList.Count == 0)
        {
          return false;
        }
        return true;
    }
    public bool CheckId(int eId)
    {
        var eidexist = EmployeeList.Find(item => item.EmployeeId == eId);
            if (eidexist != null)
            {
                return true;
            }
            return false;
    }

    public Employee GetById(int eId)
        {
            var eidexist = EmployeeList.Find(item => item.EmployeeId == eId);
            return eidexist;

        }
    public void Delete(int eId)
        {
            var employees=EmployeeList.Find(employee => employee.EmployeeId==eId);
            if(employees != null)
            {
                EmployeeList.Remove(employees);
            }
        }
    public bool IsEmployeeMappedToProject(int eId)
    {
       return ProjectDomain.ProjectList.Exists(project => project.EmployeeToProjectList.Contains(eId));

       //return project.EmployeeToProjectList.Contains(eId);
       
    }
}
}
