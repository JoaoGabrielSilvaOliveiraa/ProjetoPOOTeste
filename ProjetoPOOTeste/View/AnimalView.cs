using System; 
using System.Collections.Generic;

public class AnimalView 
{
    // criando um método que seja uma lista, que guarde os sons de todos os animais dentro de uma lista String, fazendo o uso de Collections por que se fosse array teria que ser um tamanho fixo.
    public void MostrarSons(List<string> sons)
    {
        // aqui eu fiz um código que vá percorrer cada elemento dentro da lista, no caso os sons e armazene-o dentro de uma variavel chamada som.
        foreach (var som in sons)
        {
           //aqui exibe o som  no console.
            Console.WriteLine(som);
        }
    }
}
