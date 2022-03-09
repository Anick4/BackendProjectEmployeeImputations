using Imputaciones.CrossCutting.Configuration;

using Imputaciones.DataAccess.Services;

using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "PaseUsted";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name : MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("*").AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IoC.Register(builder.Services);
var appSettingsSection = builder.Configuration.GetSection("AppSettings");
string myconnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(
myconnection, ServerVersion.AutoDetect(myconnection)
)
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();  

app.UseAuthorization();

app.MapControllers();

app.Run();
