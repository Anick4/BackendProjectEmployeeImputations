using Imputaciones.CrossCutting.Configuration;
using Imputaciones.DataAccess.Services;
using Microsoft.EntityFrameworkCore;



// CORS:
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => options.AddDefaultPolicy(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true)));


// Add services to the container
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IoC.Register(builder.Services);
var appSettingsSection = builder.Configuration.GetSection("AppSettings");
string myconnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(
myconnection, ServerVersion.AutoDetect(myconnection),
(p => p.MigrationsAssembly("ImputacionesBackend"))
)
);


var app = builder.Build();

app.UseCors(); //CORS

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();