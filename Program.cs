using System;

namespace bancoAlimentosApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chama a página de Cadastro
            Cadastro();
            //Página após o login a página principal, basicamente um menu de opções
            Menu();
        }

        public static void Cadastro()
        {
            //Aqui é feita a interação da página de login com o usuário, 
            //captando o email e a senha

            //Preciso fazer uma autenticação da senha integrada ao banco de dados aqui 

            Console.WriteLine("Digite o email cadastrado:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string password = Console.ReadLine();

            CadastroEmpresas cEmpresas = new CadastroEmpresas(email, password);

            /*Console.WriteLine(cEmpresas.ToString());*/
        }
    
        public static void Menu()
        {CadastroComidaDisponivel ccd;
            
            Console.WriteLine("Página Principal");
            Console.WriteLine($@"Escolha o que quer fazer:
1 - Disponibilizar alimentos para doação
2 - Visualizar os alimentos para doaçao");
            int resposta = int.Parse(Console.ReadLine());

            switch(resposta)
            {
                case 1: CadastroComidaDisponivel.CadastroAlimentos(); break;
                case 2: VisualizacaoAlimentosDisponiveis.AlimentosDisponiveis(); break;
            }
        }
    }


}












/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
*/