var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto>produtos = new List<Produto>(){
  new Produto("Celular", "Android"),
  new Produto("Celular", "Iphone"),
  new Produto("Notebook", "Mac"),
  new Produto("Mousepad", "nsei"),
};



//End Points = Funcionalidades dentro da aplicação - Dados sempre vão retornar em JSON
app.MapPost("/api/produto", () => "Hello");

app.MapGet("/api/produto", () => produtos);


app.Run();

public record Produto(string Nome, string Descricao);
