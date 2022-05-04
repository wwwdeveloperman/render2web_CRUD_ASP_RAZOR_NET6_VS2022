using System.ComponentModel.DataAnnotations;   // [Key]

namespace CRUDNET6RAZORVS2022.Modelos
{
    public class Curso
    {
    
        // prop tab, tab
        [Key] // using ...
        public int Id { get; set; }
        
        //
        [Required]  
        [Display(Name ="Nombre de Curso")]
        public string NombreCurso  { get; set; } // subrayado, ir a las opciones de 
        // Gravedad, Silence.

        //
        [Display(Name = "Cantidad Clases")]
        public int CantidadClases { get; set; }


        [Display(Name = "Precio")]
        public int Precio { get; set; }


        [Display(Name = "Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }

    }


}// crud.Modelos
