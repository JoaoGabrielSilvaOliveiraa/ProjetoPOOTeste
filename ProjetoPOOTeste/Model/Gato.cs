public class Gato : Mamifero
{
    public Gato(string nome, int idade, string corPelo)
        : base(nome, idade, corPelo)
    {
    }

    public override string EmitirSom()
    {
        return $"{Nome} está miando.";
    }
}
