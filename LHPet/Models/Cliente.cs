namespace LHPet.Models;

public class Cliente
{
    public int _id {get; set;}
    public string? _nome { get; set; }
    public string? _cpf { get; set; }
    public string? _email {get; set;}
    public string? _paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this._id = id;
        this._nome = nome;
        this._cpf = cpf;
        this._email = email;
        this._paciente = paciente;
    }
}