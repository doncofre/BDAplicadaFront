using BDAplicada.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BDAplicada.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            List<VendedorViewModel> vendedores = new List<VendedorViewModel>
            {
                new VendedorViewModel { Nombre = "Jhon", Apellido = "Doe", VentasMes = 4001032 },
                new VendedorViewModel { Nombre = "Alice", Apellido = "Smith", VentasMes = 3204500 },
                new VendedorViewModel { Nombre = "Bob", Apellido = "Johnson", VentasMes = 2806000 },
                new VendedorViewModel { Nombre = "Eva", Apellido = "Williams", VentasMes = 2107500 },
                new VendedorViewModel { Nombre = "Carlos", Apellido = "Martinez", VentasMes = 1853000 },
                new VendedorViewModel { Nombre = "Laura", Apellido = "Brown", VentasMes = 1508200 },
                new VendedorViewModel { Nombre = "Miguel", Apellido = "García", VentasMes = 2903500 },
                new VendedorViewModel { Nombre = "Sofía", Apellido = "Lopez", VentasMes = 4209000 },
                new VendedorViewModel { Nombre = "Lucas", Apellido = "Hernandez", VentasMes = 1756000 },
                new VendedorViewModel { Nombre = "Isabel", Apellido = "Rodriguez", VentasMes = 3602000 },
                new VendedorViewModel { Nombre = "Diego", Apellido = "Perez", VentasMes = 4106000 },
                new VendedorViewModel { Nombre = "Valentina", Apellido = "Gomez", VentasMes = 2809000 },
                new VendedorViewModel { Nombre = "Mateo", Apellido = "Torres", VentasMes = 1954000 },
                new VendedorViewModel { Nombre = "Emma", Apellido = "Wilson", VentasMes = 2407500 },
                new VendedorViewModel { Nombre = "Daniel", Apellido = "Moore", VentasMes = 3302800 },
                new VendedorViewModel { Nombre = "Olivia", Apellido = "Lee", VentasMes = 2756000 },
                new VendedorViewModel { Nombre = "Alexander", Apellido = "Davis", VentasMes = 3904500 },
                new VendedorViewModel { Nombre = "Mia", Apellido = "Taylor", VentasMes = 2153200 },
                new VendedorViewModel { Nombre = "Liam", Apellido = "Anderson", VentasMes = 3106700 },
                new VendedorViewModel { Nombre = "Ava", Apellido = "White", VentasMes = 2601400 }
            };

            return View(vendedores);
        }
        public IActionResult VendedoresPorTienda(int idlocal, DateTime fechainicio, DateTime fechafin)
        {
            return View();
        }
    }
}
