using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Sirve index.html y cualquier estático en wwwroot
app.UseDefaultFiles();        // busca index.html, default.html, etc.
app.UseStaticFiles(new StaticFileOptions
{
    // Garantiza que .mp4 se sirva con el tipo MIME correcto
    ContentTypeProvider = new FileExtensionContentTypeProvider
    {
        Mappings = { [".mp4"] = "video/mp4" }
    }
});

app.Run();
