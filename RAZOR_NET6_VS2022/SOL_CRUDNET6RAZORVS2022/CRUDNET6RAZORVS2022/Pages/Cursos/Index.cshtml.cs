using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        
        // 1.
        //-----------------------------------------------------------------
        private readonly  DB   _contexto;
        public IndexModel(DB contexto)
        {
            _contexto = contexto;
        }
        //-----------------------------------------------------------------
        
        

        // 2. Obtener una lista de Cursos p usar en el html ---------------
        public IEnumerable<Curso> Cursos { get; set; }
        // ----------------------------------------------------------------



        //3. Mensaje 
        // ----------------------------------------------------------------
        [TempData]
        public string Mensaje { get; set; }
        // ----------------------------------------------------------------



        // ----------------------------------------------------------------
        // 4. OnGet()
        /*
         public async void Task OnGet()
        {
            Cursos =  await _contexto.Cursos.ToList();
        }
        */
        public void OnGet()
        {
            Cursos = _contexto.Cursos.ToList();
        }
        // ----------------------------------------------------------------




        // ----------------------------------------------------------------
        // 5.  HANDLER OnPostBorrar DESDE el .html en boton borrar
        public async Task<IActionResult> OnPostBorrar(int id)
        {
            {
                // FIND Cursos.Id
                var vFoundDB = await _contexto.Cursos.FindAsync(id);
                if (vFoundDB == null)
                {
                    return NotFound();
                }
                //:
                _contexto.Cursos.Remove(vFoundDB);
                //
                await _contexto.SaveChangesAsync();
                Mensaje = "Borrado correctamente.";
                return RedirectToPage("Index");
            }
        }// OnPostBorrar()
        // ------------------------------------------------------------------


    }//class 
}
