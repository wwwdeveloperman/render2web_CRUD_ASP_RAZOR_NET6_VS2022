using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        //----------------------------
        private readonly DB _contexto;
        public CrearModel(DB contexto)
        {
            _contexto = contexto;
        }
        //----------------------------

        // crear una instancia:
        [BindProperty]
        // using app.Modelos
        public Curso Cursos { get; set; }
        // <label asp-for="Cursos.NombreCurso"></label> <--  en el .cshtml


        public void OnGet()
        {
        }

        
        
        public async Task<IActionResult> OnPost()
        {   
            // Comprobacion de validaciones.
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //
            Cursos.FechaCreacion = DateTime.Now;
            _contexto.Add(Cursos);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");

        }//


    }//class CrearModel
}
