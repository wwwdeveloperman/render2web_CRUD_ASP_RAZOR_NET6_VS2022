using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        //----------------------------
        private readonly DB _contexto;
        public EditarModel(DB contexto)
        {
            _contexto = contexto;
        }
        //----------------------------


        // crear una instancia:
        [BindProperty]
        // using app.Modelos
        public Curso Cursos { get; set; }


        // ----------------------------
        public void OnGet()
        {
        }
    }
}
