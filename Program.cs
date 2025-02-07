using SayasingAPr_2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<AddingTwoNumbersServices>();
builder.Services.AddScoped<AskingQuestionsServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<HelloWorldServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<ResturantPickerServices>();
builder.Services.AddScoped<ReverseItAlphaServices>();
builder.Services.AddScoped<ReverseItNumbServices>();

builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAll", 
    policy=> {
        policy.AllowAnyOrigin()
              .AllowAnyMethod() 
              .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");


app.MapControllers();

app.Run();
