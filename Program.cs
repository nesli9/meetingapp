var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

//mvc
//rest api
//razor pages , gibi proje şablonları vardır.


//controller/action/id? => şeması kullanılmış olur.
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name : "default",
    pattern : "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
