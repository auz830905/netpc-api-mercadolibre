using NETPC.ApiMercadoLibre.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders().AddConsole();

builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddHttpsRedirection(options =>
{
    options.RedirectStatusCode = StatusCodes.Status308PermanentRedirect;
    options.HttpsPort = 7189;
});

builder.Services.AddSwaggerExtension();
builder.Services.AddServices(builder);

var app = builder.Build();

app.UseCors(cors => cors
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials()
);


app.ConfigureSwagger();
app.UseHttpsRedirection();

app.AddEndPointsPlayerBalanceExtension();

//app.AddGlobalErrorHandler();

app.Run();