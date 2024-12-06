public class Mamifero : Animal
{
    public string CorPelagem { get; set; }

    public Mamifero(string nome, int idade, string corPelagem)
        : base(nome, idade)
    {
        CorPelagem = corPelagem;
    }

    public override String EmitirSom()
    {
        return $"O {Nome} emite um som genérico";
    }

}





