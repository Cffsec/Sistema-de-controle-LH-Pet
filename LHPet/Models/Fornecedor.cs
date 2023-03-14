namespace LHPet.Models;

public class Fornecedor
{
    public int _id {get; set;}
    public string? _nome { get; set; }
    public string? _cnpj {get; set;}
    public string? _email {get; set;}


    public Fornecedor(int id, string nome, string cnpj, string email)
    {
        this._id = id;
        this._nome = nome;
        this._cnpj = cnpj;
        this._email = email;
    }
}
