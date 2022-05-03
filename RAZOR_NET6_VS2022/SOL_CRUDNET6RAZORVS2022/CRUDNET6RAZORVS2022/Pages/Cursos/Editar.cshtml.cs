using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class EditarModel : PageModel
    {


        //----------------------------------
        private readonly DB _contexto;
        public EditarModel(DB contexto)
        {
            _contexto = contexto;
        }
        //----------------------------------



        //----------------------------------
        // crear una instancia:
        [BindProperty]
        // using app.Modelos
        public Curso Cursos { get; set; }
        //-----------------------------------

        // ----------------------------------------------------------------
        public async void OnGet(int id)
        {
            Cursos = await _contexto.Cursos.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            // if form data is ok 
            if (ModelState.IsValid)
            {
                // Cursos.Id
                var vFoundDB = await _contexto.Cursos.FindAsync(id);
                if(vFoundDB == null)
                {
                    return NotFound();
                }



                vFoundDB.NombreCurso = Cursos.NombreCurso;
                vFoundDB.CantidadClases = Cursos.CantidadClases;
                vFoundDB.Precio = Cursos.Precio;
                //
                await _contexto.SaveChangesAsync();
                //return RedirectToPage("Index");
            }
            
            return RedirectToPage("Index");

        }// OnPost()
        // ------------------------------------------------------------------




    }
}
