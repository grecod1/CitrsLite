using CitrsLite.API.Controllers;
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

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>(u => 
    new UnitOfWork(connectionString: builder.Configuration.GetConnectionString("CitrsDatabase")));
builder.Services.AddSingleton<ParticipantService, ParticipantService>(p => 
    new ParticipantService(connectionString: builder.Configuration.GetConnectionString("CitrsDatabase")));

builder.Services.AddScoped<VarietyCloneFormViewModel>();
builder.Services.AddScoped<ParticipantFormViewModel>();
builder.Services.AddMudServices();
builder.Services.AddMudBlazorResizeListener();
builder.Services.AddHttpClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
