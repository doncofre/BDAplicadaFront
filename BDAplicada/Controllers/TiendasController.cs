using BDAplicada.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BDAplicada.Controllers
{
    public class TiendasController : Controller
    {
        public IActionResult Index()
        {
            List<TiendasViewModel> tiendas = new List<TiendasViewModel>
            {
                new TiendasViewModel { Direccion = "1234 Elm Street", VentasMes = 35000.00m },
                new TiendasViewModel { Direccion = "5678 Maple Avenue", VentasMes = 28000.50m },
                new TiendasViewModel { Direccion = "4321 Oak Lane", VentasMes = 42000.25m },
                new TiendasViewModel { Direccion = "7890 Pine Road", VentasMes = 31000.75m }
            };
            return View(tiendas);
        }
    }
}
