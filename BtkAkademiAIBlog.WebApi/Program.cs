using BtkAkademiAIBlog.WebApi.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogAIContext>();

builder.Services.AddControllers();

// .NET 10.0 ile gelen yerleşik OpenAPI servisi
builder.Services.AddOpenApi();

// --- SWAGGER İÇİN EKLENEN SERVİSLER ---
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// -------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    
    // --- SWAGGER ARAYÜZÜNÜ AKTİF EDEN ORTAM (MIDDLEWARE) ---
    app.UseSwagger();
    app.UseSwaggerUI();
    // -----------------------------------------------------
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();