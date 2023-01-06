using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U2Complementario_CarlosValdez.Models.ViewModels;

namespace U2Complementario_CarlosValdez.Controllers
{
    public class HomeController : Controller
    {
        MenuViewModel mvm =new MenuViewModel();
        U2Complementario_CarlosValdez.Models.NeatContext context=new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu1()
        {

            var menus = context.Menus.OrderBy(x => x.Nombre)
             .Select(x => new MenuViewModel
             {
                 Nombre = x.Nombre,
                 Precio = x.Precio,
                 Descripción = x.Descripción
             });
            return View(menus);
        }
        public IActionResult Menu2()
        {
            var menus = context.Menus.OrderBy(x => x.Nombre)
            .Select(x => new MenuViewModel
            {
                Id=x.Id,
                IdClasificacion=x.IdClasificacion,
                NombreClasificacion=x.IdClasificacionNavigation.Nombre,
                Nombre = x.Nombre,
                Precio = x.Precio,
                Descripción = x.Descripción
            });
            return View(menus);
        }
        [Route("/Menu3/{id?}")]
        public IActionResult Menu3(int? id)
        {
           var menus = context.Menus.OrderBy(x => x.Nombre)
          .Select(x => new MenuViewModel
          {
              Id = x.Id,
              IdClasificacion = x.IdClasificacion,
              NombreClasificacion = x.IdClasificacionNavigation.Nombre,
              Nombre = x.Nombre,
              Precio = x.Precio,
              Descripción = x.Descripción
          });
            return View(menus);
        }
    }
}
