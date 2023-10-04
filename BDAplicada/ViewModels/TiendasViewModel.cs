using BDAplicada.Controllers;

namespace BDAplicada.ViewModels
{
    public class TiendasViewModel
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public decimal VentasMes { get; set; }
        public TiendasViewModel()
        {
            
        }
        public async Task llamarControllerVendedores()
        {
            var ctrl = new VendedoresController();
            ctrl.VendedoresPorTienda(this.Id, DateTime.Now.Date.AddYears(-30), DateTime.Now.Date);
        }
    }
}
