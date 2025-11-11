using Microsoft.EntityFrameworkCore;
using TesteDWDM_FranciscoMonteiro.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração correta com SQLITE ⚠️
builder.Services.AddDbContext<VoluntariosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("VoluntariosContext")));

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();