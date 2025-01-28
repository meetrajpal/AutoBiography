    using Microsoft.EntityFrameworkCore;

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllersWithViews();

    DotNetEnv.Env.Load();

    string connectionString = Environment.GetEnvironmentVariable("DB_STR");


    builder.Services.AddDbContext<AutoBiography.Data.ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));


    builder.Services.AddHttpClient();

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
       
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
