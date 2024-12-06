public class AnimalController
{
    private List<Animal> _animais = new List<Animal>();

    public void AdicionarAnimal(Animal animal)
    {
        _animais.Add(animal);
    }

    public List<string> ObterTodosOsSons()
    {
        List<string> sons = new List<string>();
        foreach (var animal in _animais)
        {
            sons.Add(animal.EmitirSom());
        }
        return sons;
    }
}

