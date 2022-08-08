using CinemaWebApp.Business.Abstraction;
using CinemaWebApp.Business.Implementation;
using CinemaWebApp.DataAccess;
using CinemaWebApp.DataAccess.Abstraction;
using CinemaWebApp.DataAccess.Repository;
using CinemaWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepository<MovieProgram>, MovieProgramRepository>();
builder.Services.AddTransient<IMovieProgramService, MovieProgramService>();
builder.Services.AddTransient<IRepository<CinemaHall>, CinemaHallRepository>();
builder.Services.AddTransient<IRepository<Size>, SizeRepository>();
builder.Services.AddTransient<ISizeService, SizeService>();
builder.Services.AddTransient<ICinemaHallService, CinemaHallService>();
builder.Services.AddTransient<IRepository<Movie>, MovieRepository>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IRepository<Reservation>, ReservationRepository>();
builder.Services.AddTransient<IReservationService, ReservationService>();
builder.Services.AddTransient<IRepository<Snack>, SnackRepository>();
builder.Services.AddTransient<ISnackService, SnackService>();
builder.Services.AddTransient<IRepository<SnackOrder>, SnackOrderRepository>();
builder.Services.AddDbContext<CinemaAppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
