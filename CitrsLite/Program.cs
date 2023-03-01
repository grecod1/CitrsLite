using CitrsLite.Business.Repositories;
using CitrsLite.Business.Services;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Business.ViewModels.VarietyCloneViewModels;
using CitrsLite.Data;
using CitrsLite.Data.Entity;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});

// Native to Blazor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


// Mud Blazor
builder.Services.AddMudServices();
builder.Services.AddMudBlazorResizeListener();

// Service Classes
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<EmailService>();

builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>(u => 
    new UnitOfWork(connectionString: builder.Configuration!.GetConnectionString("CitrsDatabase")!));

builder.Services.AddSingleton<ParticipantService, ParticipantService>(p => 
    new ParticipantService(connectionString: builder.Configuration!.GetConnectionString("CitrsDatabase")!));



// View Models
builder.Services.AddScoped<VarietyCloneFormViewModel>();
builder.Services.AddScoped<ParticipantFormViewModel>();
builder.Services.AddScoped<ParticipantIndexViewModel>();
builder.Services.AddScoped<ParticipantDetailsViewModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");    
}

app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseAuthentication();
app.UseAuthorization();
app.MapFallbackToPage("/_Host");

// Testing publish setting
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.MapBlazorHub();

app.Run();
