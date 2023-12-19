using EntityFrameworkPractica.Repository;

var builder = WebApplication.CreateBuilder(args);


//esto es uuna forma de almacenar en ram
//builder.Services.AddDbContext<ApplicationDbContext>(p => p.UseInMemoryDatabase("TareaDB"));

//TODO: Configuracion de la conexion a BBDD 
const string nombreConexion = "miconexion";
var conexion = builder.Configuration.GetConnectionString(nombreConexion);

//TODO: Add de DbContext con la conexion    

//(importar paquetes))
///builder.Services.AddDbContext<ApplicationDbContext>(opcion => opcion.UseSqlServer(conexion));

///builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container. 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
