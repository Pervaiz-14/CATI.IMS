using IMS.Plugins.EFCore;
using IMS.Plugins.EFCore.Repositories;
using IMS.UseCases;
using IMS.UseCases.Employers;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Reports;
using IMS.WebApp.Areas.Identity;
using IMS.WebApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddSingleton<EmployerService>();

builder.Services.AddDbContext<IMSContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//DI repositories
builder.Services.AddTransient<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IInventoryTransactionRepository, InventoryTransactionRepository>();
builder.Services.AddTransient<IProductTransactionRepository, ProductTransactionRepository>();
builder.Services.AddScoped<IEmployerRepository, EmployerRepository>();
builder.Services.AddScoped<EmployerService>();

//DI use cases

builder.Services.AddScoped<IAddEmployerUseCase, AddEmployerUseCase>();
builder.Services.AddScoped<IEditEmployerUseCase, EditEmployerUseCase>();
builder.Services.AddScoped<IViewEmployersUseCase, ViewEmployersUseCase>();
builder.Services.AddScoped<IViewEmployerByIdUseCase, ViewEmployerByIdUseCase>();
builder.Services.AddScoped<IDeleteEmployerUseCase, DeleteEmployerUseCase>();

builder.Services.AddTransient<IViewInventoriesByNameUseCase, ViewInventoriesByNameUseCase>();
builder.Services.AddTransient<IAddInventoryUseCase, AddInventoryUseCase>();
builder.Services.AddTransient<IEditInventoryUseCase, EditInventoryUseCase>();
builder.Services.AddTransient<IViewInventoryByIdUseCase, ViewInventoryByIdUseCase>();

builder.Services.AddTransient<IViewProductsByNameUseCase, ViewProductsByNameUseCase>();
builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddTransient<IViewProductByIdUseCase, ViewProductByIdUseCase>();
builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IPurchaseInventoryUseCase, PurchaseInventoryUseCase>();
builder.Services.AddTransient<IValidateEnoughInventoriesForProducingUseCase, ValidateEnoughInventoriesForProducingUseCase>();
builder.Services.AddTransient<IProduceProductUseCase, ProduceProductUseCase>();
builder.Services.AddTransient<ISellProductUseCase, SellProductUseCase>();
builder.Services.AddTransient<ISearchInventoryTransactionsUseCase, SearchInventoryTransactionsUseCase>();
builder.Services.AddTransient<ISearchProductTransactionsUseCase, SearchProductTransactionsUseCase>();

var app = builder.Build();

var scope = app.Services.CreateScope();
var imsContext = scope.ServiceProvider.GetRequiredService<IMSContext>();
//imsContext.Database.EnsureDeleted();
//imsContext.Database.EnsureCreated();

var cultureInfo = new CultureInfo("ur-PK");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
