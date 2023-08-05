var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllersWithViews();

//Middleware 
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
  );

app.MapControllerRoute(
    name:"default",
    pattern:"{controller}/{action}/{Id?}"

    );


app.Run();
