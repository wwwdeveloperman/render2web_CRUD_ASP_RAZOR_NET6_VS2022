using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class EditarModel : PageModel
    {


        //----------------------------------
        //1. DB CONTEXTO
        private readonly DB _contexto;
        
        //2. COSNTRUCTOR
        public EditarModel(DB contexto)
        {
            _contexto = contexto;
        }
        //----------------------------------



        //----------------------------------
        // 3. crear una instancia:
        [BindProperty]
        // using app.Modelos
        public Curso Cursos { get; set; }
        //-----------------------------------



        // ----------------------------------------------------------------
        // Da error 
        
        /*public async void OnGet(int id)
        {
            Cursos = await _contexto.Cursos.FindAsync(id);
        }*/

        // Metodo Sincrono :
        public void OnGet(int id)
        {
            Cursos = _contexto.Cursos.Find(id);
        }
        // ----------------------------------------------------------------




        // ----------------------------------------------------------------
        public async Task<IActionResult> OnPost()
        {
            // if form data is ok 
            if (ModelState.IsValid)
            {
                // FIND Cursos.Id
                var vFoundDB = await _contexto.Cursos.FindAsync(Cursos.Id);
                if(vFoundDB == null)
                {
                    return NotFound();
                }
                // save:
                vFoundDB.NombreCurso = Cursos.NombreCurso;
                vFoundDB.CantidadClases = Cursos.CantidadClases;
                vFoundDB.Precio = Cursos.Precio;
                //
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            
            return RedirectToPage();

        }// OnPost()
        // ------------------------------------------------------------------



    }// class EditarModel
}
