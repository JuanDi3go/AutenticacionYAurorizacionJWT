using Autorizacion_y_autenticacion_JWT.Models;

namespace Autorizacion_y_autenticacion_JWT.Constants
{
    public class EmployeeConstants
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){FirstName = "Tomas", LastName = "Oliaga", Email= "TAliaga@gmail.com"},
            new Employee(){FirstName = "Marcos", LastName = "Oliaga", Email= "MOliaga@gmail.com"},
        };
    }
}
