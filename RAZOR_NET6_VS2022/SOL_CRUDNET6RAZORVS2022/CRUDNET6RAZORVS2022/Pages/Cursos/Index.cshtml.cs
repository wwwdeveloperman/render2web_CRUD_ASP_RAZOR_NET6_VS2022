using CRUDNET6RAZORVS2022.Datos;
using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUDNET6RAZORVS2022.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        //----------------------------
        private readonly  DB   _contexto;
        public IndexModel(DB contexto)
        {
            _contexto = contexto;
        }
        //----------------------------
        
        
        // Obtener una lista de Cursos p usar en el html --
        public IEnumerable<Curso> Cursos { get; set; }
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


        // ------------------------------------------------



    }//class 
}
