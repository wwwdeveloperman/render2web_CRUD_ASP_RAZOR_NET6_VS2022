﻿using System.ComponentModel.DataAnnotations;   // [Key]

namespace CRUDNET6RAZORVS2022.Modelos
{
    public class Curso
    {
    }

    // prop tab, tab
    [Key] // using ...
    public int Id { get; set; }
    /*
    //
    [Required]  
    [Display(Name ="Nombre de Curso")]
    public string NombreCurso  { get; set; }
    
    //
    [Display(Name = "Cantidad Clases")]
    public int CantidadClases { get; set; }
    */

    /**
    [StringLength()]

    [DataType(DataType.Password)]   
    **/





}// crud.Modelos
