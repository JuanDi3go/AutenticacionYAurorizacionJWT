using Autorizacion_y_autenticacion_JWT.Models;

namespace Autorizacion_y_autenticacion_JWT.Constants
{
    public class ProductsConstants
    {
        public static List<ProductModel> Products = new List<ProductModel>()
        {
            new ProductModel()
            {
                Name = "Cocacola",
                Descripcion = "Bebida con gas"
            },new ProductModel()
            {
                Name = "Agua de la peña",
                Descripcion = "Agua de 1.5L"
            },
        };
    }
}
