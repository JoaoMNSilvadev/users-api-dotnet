using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using UsersAPI.Data;
using UsersAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Registrar Controllers
builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// 🔹 Registrar DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexãoPadrao")));


builder.Services.AddScoped<IUsuarioService, UsuarioService>();
// 🔹 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
