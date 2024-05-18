using API.Data.Context;
using API.Data.IRepository;
using API.Data.Repository;
using API.DomainModels.MappingProfile;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => 
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Servcice Registration
builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

builder.Services.AddAutoMapper(typeof(SocialMediaMappingProile));

// Social Media Context Connection
builder.Services.AddDbContext<SocialMediaContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection"));
});
// Social Media Context Connection


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
