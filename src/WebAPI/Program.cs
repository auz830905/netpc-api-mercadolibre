using NETPC.ApiMercadoLibre.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders().AddConsole();

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddSwaggerExtension();
builder.Services.AddServices(builder);

var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyMethod());
app.ConfigureSwagger();
app.UseHttpsRedirection();

app.AddEndPointsPlayerBalanceExtension();

//app.AddGlobalErrorHandler();

app.Run();