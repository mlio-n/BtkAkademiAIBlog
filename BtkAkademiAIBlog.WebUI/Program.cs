var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// .NET 6'nın sorunsuz statik dosya okuyucusu
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// .NET 9'un MapStaticAssets kodlarını tamamen temizledik, klasik rota bıraktık:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();