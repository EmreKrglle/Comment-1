using TMDB.Abstract;
using TMDB.Business.Abstract;
using TMDB.Business.Concrete;
using TMDB.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy
            .WithOrigins("http://localhost:3000") // React portunu yaz
            .AllowAnyHeader()
            .AllowAnyMethod());
});
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITMDBRepo, TMDBRepositry>();
builder.Services.AddScoped<ITasksServices, TasksManager>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
