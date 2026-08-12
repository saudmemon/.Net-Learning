var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();

// OpenAPI + Swagger
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// OpenAPI + Swagger UI
app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();