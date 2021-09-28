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
    public class EditEnfermeraModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Enfermera enfermera { get; set; }
        public EditEnfermeraModel(IRepositorioEnfermera repositorioEnfermera){
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public void OnGet(int cedula)
        {
            enfermera = repositorioEnfermera.getEnfermera(cedula);
        }

        public IActionResult OnPost(Enfermera enfermera){
            try{
                repositorioEnfermera.editEnfermera(enfermera);
                return RedirectToPage("./ListEnfermera");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}