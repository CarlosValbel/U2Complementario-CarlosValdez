var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
//app.UseEndpoints(e => e.MapDefaultControllerRoute());
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
