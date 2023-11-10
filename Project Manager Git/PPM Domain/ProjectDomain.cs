using System.Collections.Generic;
using System.Text.RegularExpressions;
using PPM.Model;

namespace PPM.Domain
{
    public class ProjectDomain
    {
        Project project = new Project();
        public static List<Project> ProjectList = new List<Project>();
        public bool ProjectId(int pId)
        {
            var pidexist = ProjectList.Find(item => item.ProjectId == pId);
            if (pidexist != null)
            {
                return false;
            }
            return true;
        }
        // public bool ProjectStartDate(DateOnly startDate)
        // {
        //     if (startDate < DateOnly.Today)
        //     {
        //         return true;
        //     }
        //     return false;
        // }
        public bool ProjectEndDate(DateTime endDate, DateTime startDate)
        {
            if (endDate < startDate)
            {
                return true;
            }
            return false;
        }
        public void Add(Project projectDomain)
        {
            //Adding project details to list
            ProjectList.Add(projectDomain);
        }
        public bool CheckEmployeeId(int eId)
        {
            var eidexist = EmployeeDomain.EmployeeList.Find(item => item.EmployeeId == eId);
            if (eidexist != null)
            {
                return true;
            }
            return false;
        }
        public void AddEmpToProject(int pId, int eId)
        {
            var projects = ProjectList.SingleOrDefault(p => p.ProjectId == pId);
            //projects.EmployeeToProjectList ??= new();
            if (projects != null)
            {
                //Adding project details to list
                projects.EmployeeToProjectList.Add(eId);
            }
        }
        public void RemoveEmpFromProject(int pId, int eId)
        {
            var projects = ProjectList.SingleOrDefault(p => p.ProjectId == pId);
            //removing project details from list
            if (projects != null)
            {
                projects.EmployeeToProjectList.Remove(eId);
            }
        }
        public bool CheckProjectList()
        {
            if (ProjectList.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckId(int pId)
        {
            var pidexist = ProjectList.Find(item => item.ProjectId == pId);
            if (pidexist != null)
            {
                return true;
            }
            return false;
        }
        public Project GetById(int pId)
        {
            var pidexist = ProjectList.Find(item => item.ProjectId == pId);
            return pidexist;

        }
        public void Delete(int pId)
        {
            var projects=ProjectList.Find(project => project.ProjectId==pId);
            if(projects != null)
            {
                ProjectList.Remove(projects);
            }
        }
        public bool CheckEmpToProjectList(int pId)
        {
            var projects = ProjectList.SingleOrDefault(p => p.ProjectId == pId);
            //projects.EmployeeToProjectList ??=new();   
            if (projects.EmployeeToProjectList.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}