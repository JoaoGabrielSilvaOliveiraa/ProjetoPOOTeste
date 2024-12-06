// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // aqui vou inicializar as minhas Controllers
        AnimalController controller = new AnimalController();
        AnimalView view = new AnimalView();

        // fazendo o teste, criando os animais
        Animal gato = new Gato("Mingau", 2, "Branco");
        Animal cachorro = new Mamifero("Rex", 4, "Marrom");

        // adicionando os animais na minha Controller
        controller.AdicionarAnimal(gato);
        controller.AdicionarAnimal(cachorro);

        //aqui é pra eu conseguir obter todos os sons
        var sons = controller.ObterTodosOsSons();
        view.MostrarSons(sons);
    }
}
