public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;

    }

    public abstract string EmitirSom();
}
