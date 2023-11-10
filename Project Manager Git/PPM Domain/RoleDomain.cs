using System.Collections.Generic;
using System.Text.RegularExpressions;
using PPM.Model;

namespace PPM.Domain
{
    public class RoleDomain
    {
        public static List<Role> RoleList = new List<Role>();
        public bool RoleId(int rId)
        {
            var ridexist = RoleList.Find(item => item.RoleId == rId);
            if (ridexist != null)
            {
                return false;
            }
            return true;
        }
        public void Add(Role roleDomain)
        {
            //Adding role details to list
            RoleList.Add(roleDomain);
        }
        public bool CheckRoleList()
        {
            if (RoleList.Count == 0)
            {
                return false;
            }
            return true;
        }
        public bool CheckId(int rId)
        {
            var ridexist = RoleList.Find(item => item.RoleId == rId);
            if (ridexist != null)
            {
                return true;
            }
            return false;
        }
        public Role GetById(int rId)
        {
            var ridexist = RoleList.Find(item => item.RoleId == rId);
            return ridexist;

        }
        public void Delete(int rId)
        {
            var roles=RoleList.Find(role => role.RoleId==rId);
            if(roles != null)
            {
                RoleList.Remove(roles);
            }
        }
        public bool IsRoleMappedToEmployee(int rId)
        {
            return EmployeeDomain.EmployeeList.Any(item=>item.EmployeeRoleId==rId);
        }

    }
}