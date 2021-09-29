using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalEnCasa.App.FrontEnd
{
    public class ListAnotacionModel : PageModel
    {
        private readonly IRepositorioAnotacion repositorioAnotacion;
        public IEnumerable<Anotacion> anotaciones;

        public ListAnotacionModel(IRepositorioAnotacion repositorioAnotacion){
            this.repositorioAnotacion = repositorioAnotacion;
        }
        public void OnGet()
        {
            anotaciones = repositorioAnotacion.getAllAnotacion();
        }
    }
}
