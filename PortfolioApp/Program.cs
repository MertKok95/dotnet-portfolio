using Microsoft.EntityFrameworkCore;
using PortfolioApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Entity Framework ve SQLite entegrasyonu
builder.Services.AddDbContext<PortfolioApp.Data.PortfolioDbContext>(options =>
    options.UseSqlite("Data Source=portfolio.db"));

// Servis katmanı kaydı
builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();

// Uygulama başlarken veritabanını oluştur ve güncellemeleri (Seed Data dahil) uygula
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PortfolioApp.Data.PortfolioDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
