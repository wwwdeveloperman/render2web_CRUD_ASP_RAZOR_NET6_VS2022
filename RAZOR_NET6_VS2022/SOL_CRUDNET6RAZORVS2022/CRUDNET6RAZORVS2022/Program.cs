//
// AGREGAR SERVICIOS :
using CRUDNET6RAZORVS2022.Datos;
using Microsoft.EntityFrameworkCore; // para options.UseSqlServer()
// UseSqlServer() ->  instalar NuGets.

//
//
var builder = WebApplication.CreateBuilder(args);

// --------- Configurar conexion a SQL SERVER :
builder.Services.AddDbContext<DB>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("str")));
// -------------------------------------------------------------------






// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();




//
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}




app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


//end