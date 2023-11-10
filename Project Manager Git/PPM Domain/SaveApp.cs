using System.Xml.Serialization;
using PPM.Model;

namespace PPM.Domain
{

    public class SerializeData
    {
        // readonly Project projectobj = new();
        public void SaveState()
        {
            string ProjectFile =
                @"C:\Users\MReddygari\Documents\PPM_Project_SME\Prolifics_Project_Module\PPM.XML\ProjectData.xml";
            string EmployeeFile =
                @"C:\Users\MReddygari\Documents\PPM_Project_SME\Prolifics_Project_Module\PPM.XML\EmployeeData.xml";
            string RoleFile =
                @"C:\Users\MReddygari\Documents\PPM_Project_SME\Prolifics_Project_Module\PPM.XML\RoleData.xml";


            using (TextWriter projectWriter = new StreamWriter(ProjectFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Project>));
                serializer.Serialize(projectWriter, ProjectDomain.ProjectList);
            }

            using (TextWriter employeeWriter = new StreamWriter(EmployeeFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                serializer.Serialize(employeeWriter, EmployeeDomain.EmployeeList);
            }

            using (TextWriter roleWriter = new StreamWriter(RoleFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Role>));
                serializer.Serialize(roleWriter, RoleDomain.RoleList);
            }


        }
    }
}
