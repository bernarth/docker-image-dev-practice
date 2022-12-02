using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnectionConfig = new ConfigurationConnection(builder.Configuration.GetConnectionString("MySqlConnection"));
builder.Services.AddSingleton(ConnectionConfig);

builder.Services.AddScoped<IPersonRepository, PersonRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
