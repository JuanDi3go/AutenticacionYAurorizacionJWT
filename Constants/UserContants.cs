using Autorizacion_y_autenticacion_JWT.Models;

namespace Autorizacion_y_autenticacion_JWT.Constants
{
    public class UserContants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { UserName = "jPerez", Password= "admin123", Rol = "Administrador", EmailAddress = "juan@gmail.com", FirstName = "Juan diego", LastName = "angel"},
            new UserModel() { UserName = "Mgomez", Password= "admin123", Rol = "Vendedor", EmailAddress = "Maria@gmail.com", FirstName = "maria", LastName = "angel"},
        };


    }
}
