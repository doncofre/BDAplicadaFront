using BDAplicada.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BDAplicada.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            List<ProductoViewModel> productos = new List<ProductoViewModel>
            {
                new ProductoViewModel { Modelo = "iPhone 13", Precio = 799.99m },
                new ProductoViewModel { Modelo = "iPad Pro", Precio = 999.00m },
                new ProductoViewModel { Modelo = "MacBook Air", Precio = 1299.99m },
                new ProductoViewModel { Modelo = "Apple Watch Series 7", Precio = 399.00m },
                new ProductoViewModel { Modelo = "AirPods Pro", Precio = 249.99m },
                new ProductoViewModel { Modelo = "iMac", Precio = 1499.99m },
                new ProductoViewModel { Modelo = "Mac Mini", Precio = 699.00m },
                new ProductoViewModel { Modelo = "HomePod Mini", Precio = 99.00m }
            };
            return View(productos);
        }
    }
}
