using CRUDNET6RAZORVS2022.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CRUDNET6RAZORVS2022.Datos
{   


    // EntitiFrameworkCore -> DbContext -------------------
    public class DB : DbContext 
    {
        public DB(DbContextOptions<DB> opt ) : base(opt)
        { }

        // MODELOS
        public DbSet<Curso> Cursos { get; set; }

    }// class DB ------------------------------------------


}// namespace
