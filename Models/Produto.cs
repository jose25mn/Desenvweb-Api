namespace MeuCrud.Api.Models;

public class Produto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
}
