using TMDB.Abstract;
using TMDB.Business.Abstract;
using TMDB.Business.Concrete;
using TMDB.Concrete;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITMDBRepo, TMDBRepositry>();
builder.Services.AddScoped<ICommentsServices, CommentsManager>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
